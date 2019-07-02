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
        public Action<bool, Publisher<T>, string> OnRegistered { get; internal set; }
        internal Publisher(RoslinNode node, string topic) : base(node) => Topic = topic;
        bool canSend;
        internal override async Task<bool> Register()
        {
            MasterSlaveApi.OnRequestTopic(RosNodeUri, OnRequestTopic);
            TcpListener = new TcpListenerPub(RosNodeUri.Host, Utils.GetFreePort());
            TcpListener.Start();
            TcpListener.BeginAcceptTcpClient(OnClientConnected, TcpListener);
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
        private async void OnClientConnected(IAsyncResult ar)
        {
            if (TcpListener.Active)
            {
                var client = TcpListener.EndAcceptTcpClient(ar);
                Thread.Sleep(100);
                var ns = client.GetStream();
                if (ns.CanRead && ns.DataAvailable)
                {
                    var conn = new Connection();
                    conn.Read(ns);
                    if (conn.Type == "*" || (Topic == conn.Topic && Type == conn.Type && Md5Sum == conn.Md5Sum))
                    {
                        if (ns.CanWrite)
                        {
                            conn.CallerID = NodeName;
                            conn.Write(ns);
                            TcpClients.Add(client);
                            if (LatchStream != null)
                            {
                                await SendStream(client, LatchStream);
                            }
                            canSend = true;
                        }
                    }
                    else
                    {
                        throw new Exception($"Topic to pub : {Topic}|{Type}|{Md5Sum}\nTopic to sub :{conn.Topic}:{conn.Type}:{conn.Md5Sum}");
                    }
                }
                TcpListener.BeginAcceptTcpClient(OnClientConnected, TcpListener);
            }
        }
        internal override async Task<bool> UnRegister()
        {
            TcpListener.Stop();
            MasterSlaveApi.RemoveListenUri(RosNodeUri);
            return (await MasterSlaveApi.UnregisterPublisher(this)).Code == 1;
        }
        private ResponseRequestTopic OnRequestTopic(RequestRequestTopic request)
        {
            if (request.Topic == Topic)
            {
                return new ResponseRequestTopic(1, "ok") { Protocol = "TCPROS", Host = RosNodeUri.Host, Port = TcpListener.Port };
            }
            else
            {
                return new ResponseRequestTopic(-1, $"topic {request.Topic} not equals needs {Topic}");
            }
        }
        public async Task PublishTopic(T topic, bool latch = false)
        {
            for (int i = 0; i < TcpClients.Count; i++)
            {
                if (!TcpClients[i].Connected)
                {
                    TcpClients.Remove(TcpClients[i--]);
                }
            }
            if (canSend)
            {
                canSend = false;
                if (LatchStream != null)
                {
                    LatchStream.Dispose();
                }
                LatchStream = new MemoryStream();
                topic.Serilize(new BinaryWriter(LatchStream));
                foreach (var item in TcpClients)
                {
                    await SendStream(item, LatchStream);
                }
                if (!latch)
                {
                    LatchStream.Dispose();
                    LatchStream = null;
                }
                canSend = true;
            }
        }

        private async Task SendStream(TcpClient client, Stream stream)
        {
            Socket socket = client.Client;
            if (socket.Poll(1000, SelectMode.SelectRead) && socket.Available == 0)
            {
                client.Close();
                return;
            }
            NetworkStream networkStream = client.GetStream();
            if (networkStream.CanWrite)
            {
                stream.Position = 0;
                var lenBytes = BitConverter.GetBytes((int)stream.Length);
                await networkStream.WriteAsync(lenBytes, 0, lenBytes.Length);
                await stream.CopyToAsync(networkStream);
            }
            else
            {
                networkStream.Close();
                throw new Exception("tcp client can not write");
            }
        }
    }
}