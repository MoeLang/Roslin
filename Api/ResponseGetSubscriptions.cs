using System.Collections;
using System.Collections.Generic;

namespace Roslin.Api
{
    public class ResponseGetSubscriptions : Response
    {
        public Dictionary<string, string> Subscriptions { get; } = new Dictionary<string, string>();
        public ResponseGetSubscriptions(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = response[0] as IList;
                if (array[2] != null && array[2] is IList)
                {
                    array = array[2] as IList;
                    foreach (var item in array)
                    {
                        if (item != null && item is IList)
                        {
                            var pair = item as IList;
                            if (pair[0] != null && pair[1] != null && pair[0] is string && pair[1] is string && pair.Count == 2)
                            {
                                Subscriptions.Add(pair[0] as string, pair[1] as string);
                            }
                        }
                    }
                }
            }
        }
    }
}
