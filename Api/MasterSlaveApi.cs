using Roslin.XmlRpc;
using System;
using System.Threading.Tasks;

namespace Roslin.Api
{
    public static class MasterSlaveApi
    {
        const string defaultCallId = "/roslin";
        public static async Task<ResponseGetSystemState> GetSystemState(Uri uri, string call_id = null) => new ResponseGetSystemState(await Rpc.MethodCall(uri, "getSystemState", call_id ?? defaultCallId));
        public static async Task<ResponseLookupNode> LookupNode(Uri uri, string node_name, string call_id = null) => new ResponseLookupNode(await Rpc.MethodCall(uri, "lookupNode", call_id ?? defaultCallId, node_name));
        public static async Task<ResponseGetSubscriptions> GetSubscriptions(Uri uri, string call_id = null) => new ResponseGetSubscriptions(await Rpc.MethodCall(uri, "getSubscriptions", call_id ?? defaultCallId));
        public static async Task<ResponseGetPublications> GetPublications(Uri uri, string call_id = null) => new ResponseGetPublications(await Rpc.MethodCall(uri, "getPublications", call_id ?? defaultCallId));
        public static async Task<ResponseGetBusInfo> GetBusInfo(Uri uri, string call_id = null) => new ResponseGetBusInfo(await Rpc.MethodCall(uri, "getBusInfo", call_id ?? defaultCallId));
        public static async Task<ResponseRequestTopic> RequestTopic(Uri uri, string topic, string call_id = null, string protocol = "TCPROS") => new ResponseRequestTopic(await Rpc.MethodCall(uri, "requestTopic", call_id ?? defaultCallId, topic, new string[][] { new string[] { protocol } }));
        public static async Task<ResponseRegisterSubscriber> RegisterSubscriber(Uri uri, string topic, string topic_type, Uri caller_uri, string call_id = null) => new ResponseRegisterSubscriber(await Rpc.MethodCall(uri, "registerSubscriber", call_id ?? defaultCallId, topic, topic_type, caller_uri.ToString()));
        public static async Task<ResponseRegisterSubscriber> RegisterSubscriber(IMasterApiContainer masterApiContainer) => await RegisterSubscriber(masterApiContainer.ROS_MASTER_URI, masterApiContainer.Topic, masterApiContainer.Type, masterApiContainer.ROS_NODE_URI, masterApiContainer.Node);
        public static async Task<ResponseUnregisterSubscriber> UnregisterSubscriber(Uri uri, string topic, Uri caller_uri, string call_id = null) => new ResponseUnregisterSubscriber(await Rpc.MethodCall(uri, "unregisterSubscriber", call_id ?? defaultCallId, topic, caller_uri.ToString()));
        public static async Task<ResponseUnregisterSubscriber> UnregisterSubscriber(IMasterApiContainer masterApiContainer) => await UnregisterSubscriber(masterApiContainer.ROS_MASTER_URI, masterApiContainer.Topic, masterApiContainer.ROS_NODE_URI, masterApiContainer.Node);
        public static async Task<ResponseRegisterPublisher> RegisterPublisher(Uri uri, string topic, string topic_type, Uri caller_uri, string call_id = null) => new ResponseRegisterPublisher(await Rpc.MethodCall(uri, "registerPublisher", call_id ?? defaultCallId, topic, topic_type, caller_uri.ToString()));
        public static async Task<ResponseRegisterPublisher> RegisterPublisher(IMasterApiContainer masterApiContainer) => await RegisterPublisher(masterApiContainer.ROS_MASTER_URI, masterApiContainer.Topic, masterApiContainer.Type, masterApiContainer.ROS_NODE_URI, masterApiContainer.Node);
        public static async Task<ResponseUnregisterPublisher> UnregisterPublisher(Uri uri, string topic, Uri caller_uri, string call_id = null) => new ResponseUnregisterPublisher(await Rpc.MethodCall(uri, "unregisterPublisher", call_id ?? defaultCallId, topic, caller_uri.ToString()));
        public static async Task<ResponseUnregisterPublisher> UnregisterPublisher(IMasterApiContainer masterApiContainer) => await UnregisterPublisher(masterApiContainer.ROS_MASTER_URI, masterApiContainer.Topic, masterApiContainer.ROS_NODE_URI, masterApiContainer.Node);
        public static void OnPublisherUpdate(Uri uri, Func<RequestPublisherUpdate, ResponsePublisherUpdate> action) => Rpc.GetRpc(uri).BindAction("publisherUpdate", (_) => action?.Invoke(new RequestPublisherUpdate(_)).ToObj());
        public static void OnRequestTopic(Uri uri, Func<RequestRequestTopic, ResponseRequestTopic> action) => Rpc.GetRpc(uri).BindAction("requestTopic", (_) => action?.Invoke(new RequestRequestTopic(_)).ToObj());
        public static void RemoveListenUri(Uri uri) => Rpc.GetRpc(uri)?.Dispose();
    }
}