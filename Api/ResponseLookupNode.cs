using System.Collections;

namespace Roslin.Api
{
    public class ResponseLookupNode : Response
    {
        public string Uri { get; }
        public ResponseLookupNode(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = response[0] as IList;
                if (array[2] != null && array[2] is string)
                {
                    Uri = array[2] as string;
                }
            }
        }
    }
}
