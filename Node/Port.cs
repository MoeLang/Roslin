﻿using Roslin.Api;
using System;
using System.Threading.Tasks;

namespace Roslin.Node
{
    public abstract class Port : IMasterApiContainer
    {
        public string NodeName => RoslinNode.NodeName;
        public Uri RosMasterUri => RoslinNode.RosMasterUri;
        public Uri RosNodeUri => RoslinNode.RosNodeUri;
        public int PortNum { get; protected set; }
        public string Topic { get; protected set; }
        public abstract string Type { get; }
        RoslinNode RoslinNode { get; }
        public Port(RoslinNode roslinNode) { RoslinNode = roslinNode; }
        internal abstract Task<bool> Register(int port_offset = 5001);
        internal abstract Task<bool> UnRegister();
    }
}
