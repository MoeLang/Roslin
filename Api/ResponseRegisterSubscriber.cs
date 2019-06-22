using System.Collections;

namespace Roslin.Api
{
    public class ResponseRegisterSubscriber : Response
    {
        public string[] Publishers { get; }
        public ResponseRegisterSubscriber(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = response[0] as IList;
                if (array[2] != null && array[2] is IList)
                {
                    array = array[2] as IList;
                    Publishers = new string[array.Count];
                    for (int i = 0; i < Publishers.Length; i++)
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
}
