using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Roslin.Node
{
    public class Connection
    {
        public string CallerID { get; internal set; }
        public string Latching { get; internal set; }
        public string Md5Sum { get; internal set; }
        public string MessageDefinition { get; internal set; }
        public string Topic { get; internal set; }
        public string Type { get; internal set; }
        public string TcpNoDdelay { get; internal set; }
        internal void Read(NetworkStream networkStream)
        {
            BinaryReader binaryReader = new BinaryReader(networkStream);
            int length = binaryReader.ReadInt32();
            int current = 0;
            while (length > current)
            {
                var len = binaryReader.ReadInt32();
                current += len + 4;
                string data = Encoding.UTF8.GetString(binaryReader.ReadBytes(len));
                var str = data.Split('=');
                if (str.Length > 1)
                {
                    switch (str[0])
                    {
                        case "callerid":
                            CallerID = str[1];
                            break;
                        case "latching":
                            Latching = str[1];
                            break;
                        case "md5sum":
                            Md5Sum = str[1];
                            break;
                        case "message_definition":
                            MessageDefinition = str[1];
                            break;
                        case "topic":
                            Topic = str[1];
                            break;
                        case "type":
                            Type = str[1];
                            break;
                        case "tcp_nodelay":
                            TcpNoDdelay = str[1];
                            break;
                        default:
                            throw new Exception($"Unknow string {str[0]}={str[1]}");
                    }
                }
                else
                {
                    throw new Exception($"Unknow data {data}");
                }
            }
        }
        internal void Write(NetworkStream networkStream)
        {
            string callerid = "callerid=" + CallerID;
            string topic = "topic=" + Topic;
            string message_definition = "message_definition=" + MessageDefinition;
            string md5sum = "md5sum=" + Md5Sum;
            string type = "type=" + Type;
            var bw = new BinaryWriter(networkStream);
            bw.Write(
                4 + message_definition.Length +
                4 + callerid.Length +
                4 + topic.Length +
                4 + md5sum.Length +
                4 + type.Length);
            WriteString(bw, callerid);
            WriteString(bw, topic);
            WriteString(bw, message_definition);
            WriteString(bw, md5sum);
            WriteString(bw, type);
            networkStream.Flush();
        }
        public void WriteString(BinaryWriter bw, string data)
        {
            bw.Write(data.Length);
            bw.Write(Encoding.UTF8.GetBytes(data));
        }
    }
}