using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Roslin.Node
{
    internal static class Utils
    {
        static HashSet<int> usedPorts = new HashSet<int>();
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