using Roslin.Api;
using Roslin.Msg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roslin.Node
{
    public class Subscriber<T> : Port where T : RosMsg, new()
    {
        public override string Type => MsgInfo.MsgType<T>();
        public string Md5Sum => MsgInfo.MsgMd5<T>();
        public string MessageDefinition => MsgInfo.MsgDef<T>();
        public Action<T> OnTopic { get; set; }
        Dictionary<Uri, TcpClientSub<T>> Connects { get; set; } = new Dictionary<Uri, TcpClientSub<T>>();
        public Action<bool, Subscriber<T>, string> OnRegistered { get; internal set; }
        internal Subscriber(RoslinNode node, string topic) : base(node) => Topic = topic;
        internal override async Task<bool> Register(int port_offset = 5001)
        {
            MasterSlaveApi.OnPublisherUpdate(RosNodeUri, OnPublisherUpdate);
            var ret = await MasterSlaveApi.RegisterSubscriber(this);
            if (ret.Code == 1)
            {
                OnRegistered?.Invoke(true, this, ret.StatusMessage);
                UpdatePublishers(ret.Publishers.Select(_ => new Uri(_)));
                return true;
            }
            else
            {
                OnRegistered?.Invoke(false, this, ret.StatusMessage);
                return false;
            }
        }
        internal override async Task<bool> UnRegister()
        {
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
            MasterSlaveApi.RemoveListenUri(RosNodeUri);
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
                await MasterSlaveApi.RequestTopic(item, Topic, NodeName).ContinueWith(_ => Connects[item] = new TcpClientSub<T>(_.Result.Host, _.Result.Port, NodeName, Topic, OnTopic));
            }
        }
    }
}