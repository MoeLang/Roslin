using Roslin.Api;
using Roslin.Msg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Roslin.Node
{
    public class Publisher<T> : Port where T : RosMsg, new()
    {
        public override string Type => MsgInfo.MsgType<T>();
        public string Md5Sum => MsgInfo.MsgMd5<T>();
        public string MessageDefinition => MsgInfo.MsgDef<T>();
        List<TcpClient> TcpClients { get; set; } = new List<TcpClient>();
        TcpListenerPub TcpListener { get; set; }
        MemoryStream LatchStream { get; set; }
        public int SubscriberConnectTimeout { get; set; } = 1000;
        public Action<bool, Publisher<T>, string> OnRegistered { get; internal set; }
        internal Publisher(RoslinNode node, string topic) : base(node) => Topic = topic;
        bool sending;
        internal override async Task<bool> Register(int port_offset = 5001)
        {
            PortNum = Utils.GetFreePort(port_offset);
            TcpListener = new TcpListenerPub(RosNodeUri.Host, PortNum);
            TcpListener.Start();
            TcpListener.BeginAcceptTcpClient(new AsyncCallback(OnClientConnected), TcpListener);
            var ret = await MasterSlaveApi.RegisterPublisher(this);
            if (ret.Code == 1)
            {
                OnRegistered?.Invoke(true, this, ret.StatusMessage);
                return true;
            }
            else
            {
                OnRegistered?.Invoke(false, this, ret.StatusMessage);
                return false;
            }
        }
        private void OnClientConnected(IAsyncResult ar)
        {
            if (TcpListener.Active)
            {
                var client = TcpListener.EndAcceptTcpClient(ar);
                TcpListener.BeginAcceptTcpClient(new AsyncCallback(OnClientConnected), TcpListener);
                var ns = client.GetStream();
                for (int i = 0; i < SubscriberConnectTimeout; i++)
                {
                    Thread.Sleep(1);
                    if (ns.CanRead && ns.DataAvailable)
                    {
                        var conn = new Connection();
                        conn.Read(ns);
                        if (conn.Type == "*")
                        {
                            conn.Type = Type;
                            conn.Md5Sum = Md5Sum;
                            conn.MessageDefinition = MessageDefinition;
                        }
                        if (Topic == conn.Topic && Type == conn.Type && Md5Sum == conn.Md5Sum)
                        {
                            if (ns.CanWrite)
                            {
                                conn.CallerID = NodeName;
                                conn.Write(ns);
                                TcpClients.Add(client);
                                if (LatchStream != null)
                                {
                                    SendStream(client, LatchStream);
                                }
                            }
                        }
                        else
                        {
                            throw new Exception($"Topic to pub : {Topic}|{Type}|{Md5Sum}\nTopic to sub :{conn.Topic}:{conn.Type}:{conn.Md5Sum}");
                        }
                        break;
                    }
                }
            }
        }
        internal override async Task<bool> UnRegister()
        {
            TcpListener.Stop();
            MasterSlaveApi.RemoveListenUri(RosNodeUri);
            return (await MasterSlaveApi.UnregisterPublisher(this)).Code == 1;
        }
        public void PublishTopic(T topic, bool latch = false, int writeTimeout = 100)
        {
            if (!sending)
            {
                try
                {
                    sending = true;
                    if (LatchStream != null)
                    {
                        LatchStream.Dispose();
                    }
                    LatchStream = new MemoryStream();
                    topic.Serilize(new BinaryWriter(LatchStream));
                    foreach (var item in TcpClients)
                    {
                        SendStream(item, LatchStream, writeTimeout);
                    }
                    for (int i = 0; i < TcpClients.Count; i++)
                    {
                        if (!TcpClients[i].Connected)
                        {
                            TcpClients.Remove(TcpClients[i--]);
                        }
                    }
                    if (!latch)
                    {
                        LatchStream.Dispose();
                        LatchStream = null;
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    sending = false;
                }
            }
        }
        private void SendStream(TcpClient client, Stream stream, int writeTimeout = 100)
        {
            stream.Position = 0;
            if (client.Connected)
            {
                NetworkStream networkStream = client.GetStream();
                networkStream.WriteTimeout = writeTimeout;
                var lenBytes = BitConverter.GetBytes((int)stream.Length);
                networkStream.Write(lenBytes, 0, lenBytes.Length);
                stream.CopyTo(networkStream);
            }
        }
    }
}