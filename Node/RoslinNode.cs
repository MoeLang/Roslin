using Roslin.Api;
using Roslin.Msg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Roslin.Node
{
    public class RoslinNode : IDisposable
    {
        public Uri RosMasterUri { get; }
        public IPAddress RosIP { get; }
        public string NodeName { get; }
        public Uri RosNodeUri { get; }
        public RoslinNode(Uri ros_master_uri, int port_offset = 5001, IPAddress ros_ip = null, string node_name = null)
        {
            RosMasterUri = ros_master_uri;
            RosIP = ros_ip ?? LocalIPAddress;
            NodeName = node_name ?? ("/" + AppDomain.CurrentDomain.FriendlyName).Replace(' ', '_');
            RosNodeUri = new Uri($"http://{RosIP}:{Utils.GetFreePort(port_offset)}/");
            MasterSlaveApi.OnRequestTopic(RosNodeUri, OnRequestTopic);
        }
        private ResponseRequestTopic OnRequestTopic(RequestRequestTopic request)
        {
            if (Publishers.ContainsKey(request.Topic))
            {
                var target = Publishers[request.Topic];
                return new ResponseRequestTopic(1, "ok") { Protocol = "TCPROS", Host = RosNodeUri.Host, Port = target.PortNum };
            }
            else
            {
                return new ResponseRequestTopic(-1, $"Can't find topic {request.Topic}");
            }
        }
        public IPAddress LocalIPAddress
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
        Dictionary<string, Port> Publishers { get; } = new Dictionary<string, Port>();
        Dictionary<string, Port> Subscribers { get; } = new Dictionary<string, Port>();
        Queue<Port> Ports { get; } = new Queue<Port>();
        bool registering;
        public void RegisterPublisher<T>(string topic, Action<bool, Publisher<T>, string> onRegistered, int port_offset = 5001) where T : RosMsg, new()
        {
            if (Publishers.ContainsKey(topic))
            {
                onRegistered.Invoke(false, Publishers[topic] as Publisher<T>, $"Publisher for topic {topic} already existed!");
            }
            else
            {
                var publisher = new Publisher<T>(this, topic) { OnRegistered = onRegistered };
                Publishers.Add(topic, publisher);
                Ports.Enqueue(publisher);
                if (!registering)
                {
                    registering = true;
                    Task.Factory.StartNew(async () => await RegisterQueue(port_offset));
                }
            }
        }
        public void RegisterSubscriber<T>(string topic, Action<bool, Subscriber<T>, string> onRegistered, int port_offset = 5001) where T : RosMsg, new()
        {
            if (Subscribers.ContainsKey(topic))
            {
                onRegistered.Invoke(false, Subscribers[topic] as Subscriber<T>, $"Subscriber for topic {topic} already existed!");
            }
            else
            {
                var subscriber = new Subscriber<T>(this, topic) { OnRegistered = onRegistered };
                Subscribers.Add(topic, subscriber);
                Ports.Enqueue(subscriber);
                if (!registering)
                {
                    registering = true;
                    Task.Factory.StartNew(async () => await RegisterQueue(port_offset));
                }
            }
        }
        private async Task RegisterQueue(int port_offset = 5001)
        {
            await Ports.Dequeue().Register(port_offset);
            if (Ports.Count > 0)
            {
                await RegisterQueue();
            }
            else
            {
                registering = false;
            }
        }

        public async void Dispose()
        {
            while (Publishers.Count > 0)
            {
                var target = Publishers.First();
                await target.Value.UnRegister().ContinueWith(_ => Publishers.Remove(target.Key));
            }
            while (Subscribers.Count > 0)
            {
                var target = Subscribers.First();
                await target.Value.UnRegister().ContinueWith(_ => Subscribers.Remove(target.Key));
            }
        }
    }
}