using System;

namespace Roslin.Api
{
    public interface IMasterApiContainer
    {
        Uri ROS_MASTER_URI { get; }
        Uri ROS_NODE_URI { get; }
        string Topic { get; }
        string Type { get; }
        string Node { get; }
    }
}