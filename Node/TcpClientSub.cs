using Roslin.Msg;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Roslin.Node
{
    internal class TcpClientSub<Topic> : TcpClient where Topic : RosMsg, new()
    {
        Action<Topic> OnTopic { get; }
        public Action<Connection> OnConnection { get; set; }
        NetworkStream NetworkStream { get; set; }
        public Connection Connection { get; private set; }
        public TcpClientSub(string host, int port, string node_name, string topic, Action<Topic> onTopic)
        {
            OnTopic = onTopic;
            ConnectAsync(host, port).ContinueWith(_ =>
            {
                NetworkStream = GetStream();
                if (NetworkStream.CanWrite)
                {
                    new Connection
                    {
                        CallerID = node_name,
                        Topic = topic,
                        Type = MsgInfo.MsgType<Topic>(),
                        MessageDefinition = MsgInfo.MsgDef<Topic>(),
                        Md5Sum = MsgInfo.MsgMd5<Topic>()
                    }.Write(NetworkStream);
                }
                Task.Run(ReadConnection);
            });
        }
        private void ReadConnection()
        {
            if (NetworkStream.CanRead)
            {
                Connection = new Connection();
                Connection.Read(NetworkStream);
                Task.Run(ReadTopic);
                OnConnection?.Invoke(Connection);
            }
        }
        private void ReadTopic()
        {
            if (NetworkStream.CanRead)
            {
                if (new BinaryReader(NetworkStream).ReadInt32() > 0)
                {
                    Topic topic = new Topic();
                    topic.Deserilize(new BinaryReader(NetworkStream));
                    OnTopic?.Invoke(topic);
                }
                Task.Run(ReadTopic);
            }
        }
    }
}