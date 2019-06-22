using System.Collections;

namespace Roslin.Api
{
    public class ResponseRegisterPublisher : Response
    {
        public string[] Subscribers { get; }
        public ResponseRegisterPublisher(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = response[0] as IList;
                if (array[2] != null && array[2] is IList)
                {
                    array = array[2] as IList;
                    Subscribers = new string[array.Count];
                    for (int i = 0; i < Subscribers.Length; i++)
                    {
                        if (array[i] != null && array[i] is string)
                        {
                            Subscribers[i] = array[i] as string;
                        }
                    }
                }
            }
        }
    }
}
