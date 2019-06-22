using System.Collections;

namespace Roslin.Api
{
    public class ResponseRequestTopic : Response
    {
        public string Protocol { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public ResponseRequestTopic(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = response[0] as IList;
                if (array[2] != null && array[2] is IList)
                {
                    array = array[2] as IList;
                    if (array[0] != null && array[0] is string)
                    {
                        Protocol = array[0] as string;
                    }
                    if (array[1] != null && array[1] is string)
                    {
                        Host = array[1] as string;
                    }
                    if (array[2] != null && array[2] is int)
                    {
                        Port = (int)array[2];
                    }
                }
            }
        }
        public ResponseRequestTopic(int code, string status) : base(code, status) { }
        public object[] ToObj() => new object[] { new object[] { Code, StatusMessage, new object[] { Protocol, Host, Port } } };
    }
}