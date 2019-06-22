using System.Collections;

namespace Roslin.Api
{
    public class ResponseUnregisterPublisher : Response
    {
        public int NumUnregistered { get; }
        public ResponseUnregisterPublisher(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = response[0] as IList;
                if (array[2] != null && array[2] is int)
                {
                    NumUnregistered = (int)array[2];
                }
            }
        }
    }
}
