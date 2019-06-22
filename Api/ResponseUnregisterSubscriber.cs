using System.Collections;

namespace Roslin.Api
{
    public class ResponseUnregisterSubscriber : Response
    {
        public int NumUnsubscribed { get; }
        public ResponseUnregisterSubscriber(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = response[0] as IList;
                if (array[2] != null && array[2] is int)
                {
                    NumUnsubscribed = (int)array[2];
                }
            }
        }
    }
}
