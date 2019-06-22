using System.Collections;

namespace Roslin.Api
{
    public class RequestRequestTopic : Request
    {
        public string Topic { get; }
        public string[][] Protocols { get; }
        public RequestRequestTopic(object[] response) : base(response)
        {
            if (response[1] != null && response[1] is string)
            {
                Topic = response[1] as string;
            }
            if (response[2] != null && response[2] is IList)
            {
                var array = response[2] as IList;
                Protocols = new string[array.Count][];
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] != null && array[i] is IList)
                    {
                        var ar = array[i] as IList;
                        Protocols[i] = new string[ar.Count];
                        for (int j = 0; j < ar.Count; j++)
                        {
                            if (ar[j] != null && ar[j] is string)
                            {
                                Protocols[i][j] = ar[j] as string;
                            }
                        }
                    }
                }
            }
        }
    }
}
