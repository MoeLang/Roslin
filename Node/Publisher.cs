using Roslin.Api;
using Roslin.Msg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Roslin.Node
{
    public class Publisher<T> : Peer, IMasterApiContainer where T : RosMsg, new()
    {
        public string Type { get; private set; }
        public string Md5Sum { get; private set; }
        List<TcpClient> TcpClients { get; set; } = new List<TcpClient>();
        TcpListenerPub TcpListener { get; set; }
        Semaphore semaphoreList = new Semaphore(1, 1);
        Semaphore semaphoreListener = new Semaphore(1, 1);
        public Publisher(Uri master_uri, string topic, string node = null, IPAddress ros_ip = null) : base(master_uri, topic, node, ros_ip) { }
        public async Task<bool> Register()
        {
            SetupUri();
            Type = MsgInfo.MsgType<T>();
            Md5Sum = MsgInfo.MsgMd5<T>();
            MasterSlaveApi.OnRequestTopic(ROS_NODE_URI, OnRequestTopic);
            TcpListener = new TcpListenerPub(ROS_NODE_URI.Host, Utils.GetFreePort());
            TcpListener.Start();
            TcpListener.BeginAcceptTcpClient(OnClientConnected, TcpListener);
            return (await MasterSlaveApi.RegisterPublisher(this)).Code == 1;
        }
        private void OnClientConnected(IAsyncResult ar)
        {
            semaphoreListener.WaitOne();
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
                            conn.CallerID = Node;
                            conn.Write(ns);
                            semaphoreList.WaitOne();
                            TcpClients.Add(client);
                            semaphoreList.Release();
                        }
                    }
                    else
                    {
                        throw new Exception($"Topic to pub : {Topic}|{Type}|{Md5Sum}\nTopic to sub :{conn.Topic}:{conn.Type}:{conn.Md5Sum}");
                    }
                }
                TcpListener.BeginAcceptTcpClient(OnClientConnected, TcpListener);
            }
            semaphoreListener.Release();
        }
        public async Task<bool> Unregister()
        {
            semaphoreListener.WaitOne();
            TcpListener.Stop();
            semaphoreListener.Release();
            MasterSlaveApi.RemoveListenUri(ROS_NODE_URI);
            return (await MasterSlaveApi.UnregisterPublisher(this)).Code == 1;
        }
        private ResponseRequestTopic OnRequestTopic(RequestRequestTopic request)
        {
            if (request.Topic == Topic)
            {
                return new ResponseRequestTopic(1, "ok") { Protocol = "TCPROS", Host = ROS_NODE_URI.Host, Port = TcpListener.Port };
            }
            else
            {
                return new ResponseRequestTopic(-1, $"topic {request.Topic} not equals needs {Topic}");
            }
        }
        public async Task PublishTopic(T topic)
        {
            semaphoreList.WaitOne();
            for (int i = 0; i < TcpClients.Count; i++)
            {
                if (!TcpClients[i].Connected)
                {
                    TcpClients.Remove(TcpClients[i--]);
                }
            }
            semaphoreList.Release();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                topic.Serilize(new BinaryWriter(memoryStream));
                foreach (var item in TcpClients)
                {
                    Socket socket = item.Client;
                    if (socket.Poll(1000, SelectMode.SelectRead) && socket.Available == 0)
                    {
                        item.Close();
                        continue;
                    }
                    NetworkStream networkStream = item.GetStream();
                    if (networkStream.CanWrite)
                    {
                        memoryStream.Position = 0;
                        var lenBytes = BitConverter.GetBytes((int)memoryStream.Length);
                        await networkStream.WriteAsync(lenBytes, 0, lenBytes.Length).ContinueWith(async x => await memoryStream.CopyToAsync(networkStream).ContinueWith(async y => await networkStream.FlushAsync()));
                    }
                    else
                    {
                        networkStream.Close();
                        throw new Exception("tcp client can not write");
                    }
                }
            }
        }
    }
}