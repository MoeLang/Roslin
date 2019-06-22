using System.Net;
using System.Net.Sockets;

namespace Roslin.Node
{
    class TcpListenerPub : TcpListener
    {
        public int Port { get; }
        public TcpListenerPub(string host, int port) : base(IPAddress.Parse(host), port) { Port = port; }
        public TcpListenerPub(IPEndPoint localEP) : base(localEP) { Port = localEP.Port; }
        public TcpListenerPub(IPAddress localaddr, int port) : base(localaddr, port) { Port = port; }
        public new bool Active => base.Active;
    }
}
