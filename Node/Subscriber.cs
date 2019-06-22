using Roslin.Api;
using Roslin.Msg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Roslin.Node
{
    public class Subscriber<T> : Peer, IMasterApiContainer where T : RosMsg, new()
    {
        public string Type { get; private set; }
        public Action<T> OnTopic { get; set; }
        Dictionary<Uri, TcpClientSub<T>> Connects { get; set; } = new Dictionary<Uri, TcpClientSub<T>>();
        Semaphore semaphoreList = new Semaphore(1, 1);
        public Subscriber(Uri master_uri, string topic, string node = null, IPAddress ros_ip = null) : base(master_uri, topic, node, ros_ip) { }
        public async Task<bool> Register()
        {
            SetupUri();
            Type = MsgInfo.MsgType<T>();
            MasterSlaveApi.OnPublisherUpdate(ROS_NODE_URI, OnPublisherUpdate);
            var ret = await MasterSlaveApi.RegisterSubscriber(this);
            if (ret.Code == 1)
            {
                UpdatePublishers(ret.Publishers.Select(_ => new Uri(_)));
            }
            return ret.Code == 1;
        }
        public async Task<bool> Unregister()
        {
            semaphoreList.WaitOne();
            foreach (var item in Connects)
            {
                if (item.Value != null)
                {
                    if (item.Value.Connected)
                    {
                        item.Value.Close();
                    }
                    item.Value.Dispose();
                }
            }
            Connects.Clear();
            semaphoreList.Release();
            MasterSlaveApi.RemoveListenUri(ROS_NODE_URI);
            return (await MasterSlaveApi.UnregisterSubscriber(this)).Code == 1;
        }
        private ResponsePublisherUpdate OnPublisherUpdate(RequestPublisherUpdate request)
        {
            if (request.Topic == Topic)
            {
                UpdatePublishers(request.Publishers.Select(_ => new Uri(_)));
                return new ResponsePublisherUpdate(1, "ok");
            }
            else
            {
                return new ResponsePublisherUpdate(-1, $"topic {request.Topic} not equals needs {Topic}");
            }
        }
        private async void UpdatePublishers(IEnumerable<Uri> publishers)
        {
            semaphoreList.WaitOne();
            var lefted = Connects.Where(_ => !publishers.Contains(_.Key)).ToList();
            foreach (var item in lefted)
            {
                if (item.Value != null)
                {
                    if (item.Value.Connected)
                    {
                        item.Value.Close();
                    }
                    item.Value.Dispose();
                }
                Connects.Remove(item.Key);
            }
            var newcoming = publishers.Where(_ => !Connects.ContainsKey(_)).ToList();
            foreach (var item in newcoming)
            {
                Connects.Add(item, null);
                await MasterSlaveApi.RequestTopic(item, Topic, Node).ContinueWith(_ => Connects[item] = new TcpClientSub<T>(_.Result.Host, _.Result.Port, Node, Topic, OnTopic));
            }
            semaphoreList.Release();
        }
    }
}