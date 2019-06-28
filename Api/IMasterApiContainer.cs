using System;

namespace Roslin.Api
{
    public interface IMasterApiContainer
    {
        Uri RosMasterUri { get; }
        Uri RosNodeUri { get; }
        string Topic { get; }
        string Type { get; }
        string NodeName { get; }
    }
}