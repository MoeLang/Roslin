using System.Collections;

namespace Roslin.Api
{
    public class RequestPublisherUpdate : Request
    {
        public string Topic { get; }
        public string[] Publishers { get; }
        public RequestPublisherUpdate(object[] response) : base(response)
        {
            if (response[1] != null && response[1] is string)
            {
                Topic = response[1] as string;
            }
            if (response[2] != null && response[2] is IList)
            {
                var array = response[2] as IList;
                Publishers = new string[array.Count];
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] != null && array[i] is string)
                    {
                        Publishers[i] = array[i] as string;
                    }
                }
            }
        }
    }
}
