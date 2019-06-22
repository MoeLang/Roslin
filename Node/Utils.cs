using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Roslin.Node
{
    internal static class Utils
    {
        public static string CreateLocalUri() => $"http://+:{GetFreePort()}/";
        public static string LocalToOpenUri(string localUrl) => localUrl.Replace("+", LocalIPAddress.ToString());
        public static string GetHostAndPortFromUri(string uri) => uri.Replace("http://", string.Empty).TrimEnd('/');
        public static string GetHostFromUri(string uri) => GetHostAndPortFromUri(uri).Split(':')[0];
        public static int GetPortFromUri(string uri) => int.Parse(GetHostAndPortFromUri(uri).Split(':')[1]);
        public static IPAddress LocalIPAddress
        {
            get
            {
                foreach (var item in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                {
                    if (item.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return item;
                    }
                }
                return IPAddress.Loopback;
            }
        }
        static HashSet<int> usedPorts = new HashSet<int>();
        public static int GetRandomPort() => new Random((int)DateTime.Now.Ticks).Next(12345, short.MaxValue);
        public static int GetFreePort()
        {
            int port = 5001;
            HashSet<int> blockedPorts = usedPorts;
            var ipgp = IPGlobalProperties.GetIPGlobalProperties();
            foreach (var item in ipgp.GetActiveTcpConnections().Select(_ => _.LocalEndPoint.Port))
            {
                if (!usedPorts.Contains(item))
                {
                    blockedPorts.Add(item);
                }
            }
            foreach (var item in ipgp.GetActiveTcpListeners().Select(_ => _.Port))
            {
                if (!usedPorts.Contains(item))
                {
                    blockedPorts.Add(item);
                }
            }
            while (port < ushort.MaxValue)
            {
                if (blockedPorts.Contains(port))
                {
                    port++;
                    if (port == ushort.MaxValue)
                    {
                        throw new Exception("Cann't find any free port!");
                    }
                }
                else
                {
                    usedPorts.Add(port);
                    break;
                }
            }
            return port;
        }
    }
}