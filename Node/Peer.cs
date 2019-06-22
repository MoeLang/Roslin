using System;
using System.Collections.Generic;
using System.Net;

namespace Roslin.Node
{
    public abstract class Peer
    {
        public string Node { get; }
        public string Topic { get; }
        public Uri ROS_MASTER_URI { get; }
        public Uri ROS_NODE_URI { get; set; }
        public IPAddress ROS_IP { get; }
        static Dictionary<string, int> NodePorts { get; set; } = new Dictionary<string, int>();
        public Peer(Uri master_uri, string topic, string node, IPAddress ros_ip)
        {
            ROS_MASTER_URI = master_uri;
            Topic = topic;
            Node = node ?? ("/" + AppDomain.CurrentDomain.FriendlyName).Replace(' ', '_');
            ROS_IP = ros_ip ?? Utils.LocalIPAddress;
        }
        protected void SetupUri()
        {
            if (!NodePorts.ContainsKey(Node))
            {
                NodePorts.Add(Node, Utils.GetFreePort());
            }
            ROS_NODE_URI = new Uri($"http://{ROS_IP}:{NodePorts[Node]}/");
        }
    }
}