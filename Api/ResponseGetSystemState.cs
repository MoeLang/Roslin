using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Roslin.Api
{
    public class ResponseGetSystemState : Response
    {
        public ResponseGetSystemState(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = (response[0] as IList);
                if (array[2] != null && array[2] is IList)
                {
                    array = array[2] as IList;
                    if (array.Count == 3)
                    {
                        if (array[0] != null && array[0] is IList)
                        {
                            var taps = array[0] as IList;
                            TopicAndPublishers = new TopicAndPublishers[taps.Count];
                            for (int i = 0; i < taps.Count; i++)
                            {
                                if (taps[i] != null && taps[i] is IList)
                                {
                                    TopicAndPublishers[i] = new TopicAndPublishers(taps[i] as IList);
                                }
                            }
                        }
                        if (array[1] != null && array[1] is IList)
                        {
                            var tass = array[1] as IList;
                            TopicAndSubscribers = new TopicAndSubscribers[tass.Count];
                            for (int i = 0; i < tass.Count; i++)
                            {
                                if (tass[i] != null && tass[i] is IList)
                                {
                                    TopicAndSubscribers[i] = new TopicAndSubscribers(tass[i] as IList);
                                }
                            }
                        }
                        if (array[2] != null && array[2] is IList)
                        {
                            var saps = array[2] as IList;
                            ServiceAndProviders = new ServiceAndProviders[saps.Count];
                            for (int i = 0; i < saps.Count; i++)
                            {
                                if (saps[i] != null && saps[i] is IList)
                                {
                                    ServiceAndProviders[i] = new ServiceAndProviders(saps[i] as IList);
                                }
                            }
                        }
                    }
                }
            }
        }
        public TopicAndPublishers[] TopicAndPublishers { get; }
        public TopicAndSubscribers[] TopicAndSubscribers { get; }
        public ServiceAndProviders[] ServiceAndProviders { get; }
    }
    public class TopicAndPublishers
    {
        public string Topic { get; }
        public string[] Publishers { get; }
        public TopicAndPublishers(IList tap)
        {
            if (tap.Count > 1 && tap[0] != null && tap[0] is string && tap[1] != null && tap[1] is IList)
            {
                Topic = tap[0] as string;
                IList ps = tap[1] as IList;
                Publishers = new string[ps.Count];
                for (int i = 0; i < ps.Count; i++)
                {
                    if (ps[i] != null && ps[i] is string)
                    {
                        Publishers[i] = ps[i] as string;
                    }
                }
            }
        }
    }
    public class TopicAndSubscribers
    {
        public string Topic { get; }
        public string[] Subscribers { get; }
        public TopicAndSubscribers(IList tas)
        {
            if (tas.Count > 1 && tas[0] != null && tas[0] is string && tas[1] != null && tas[1] is IList)
            {
                Topic = tas[0] as string;
                IList ps = tas[1] as IList;
                Subscribers = new string[ps.Count];
                for (int i = 0; i < ps.Count; i++)
                {
                    if (ps[i] != null && ps[i] is string)
                    {
                        Subscribers[i] = ps[i] as string;
                    }
                }
            }
        }
    }
    public class ServiceAndProviders
    {
        public string Service { get; }
        public string[] Providers { get; }
        public ServiceAndProviders(IList sap)
        {
            if (sap.Count > 1 && sap[0] != null && sap[0] is string && sap[1] != null && sap[1] is IList)
            {
                Service = sap[0] as string;
                IList ps = sap[1] as IList;
                Providers = new string[ps.Count];
                for (int i = 0; i < ps.Count; i++)
                {
                    if (ps[i] != null && ps[i] is string)
                    {
                        Providers[i] = ps[i] as string;
                    }
                }
            }
        }
    }
    public static class ResponseGetSystemStateExterns
    {
        public static string[] GetNodes(this ResponseGetSystemState systemStates)
        {
            HashSet<string> nodes = new HashSet<string>();
            foreach (var item in systemStates.TopicAndPublishers)
            {
                foreach (var publisher in item.Publishers)
                {
                    if (nodes.Contains(publisher))
                    {

                    }
                    else
                    {
                        nodes.Add(publisher);
                    }
                }
            }
            foreach (var item in systemStates.TopicAndSubscribers)
            {
                foreach (var subscriber in item.Subscribers)
                {
                    if (nodes.Contains(subscriber))
                    {

                    }
                    else
                    {
                        nodes.Add(subscriber);
                    }
                }
            }
            return nodes.ToArray();
        }
    }
}