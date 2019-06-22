using System.Collections;

namespace Roslin.Api
{
    public abstract class Response
    {
        public int Code { get; }
        public string StatusMessage { get; }
        public Response(int code, string status)
        {
            Code = code;
            StatusMessage = status;
        }
        public Response(object[] response)
        {
            if (response[0] != null && response[0] is IList && (response[0] as IList).Count > 2)
            {
                var array = response[0] as IList;
                if (array[0] != null && array[0] is int)
                {
                    Code = (int)array[0];
                    if (array[1] != null && array[1] is string)
                    {
                        StatusMessage = array[1] as string;
                    }
                }
            }
        }
    }
}