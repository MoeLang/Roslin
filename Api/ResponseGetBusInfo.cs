using System.Collections;

namespace Roslin.Api
{
    public class ResponseGetBusInfo : Response
    {
        public BusInfo[] BusInfos { get; }
        public ResponseGetBusInfo(object[] response) : base(response)
        {
            if (Code == 1)
            {
                var array = response[0] as IList;
                if (array[2] != null && array[2] is IList)
                {
                    array = array[2] as IList;
                    BusInfos = new BusInfo[array.Count];
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] != null && array[i] is IList)
                        {
                            BusInfos[i] = new BusInfo(array[i] as IList);
                        }
                    }
                }
            }
        }
    }
    public class BusInfo
    {
        public int ConnectionID { get; }
        public string DestinationID { get; }
        public string Direction { get; }
        public string Transport { get; }
        public string Topic { get; }
        public int Connected { get; }
        public string Msg { get; }
        public BusInfo(IList infos)
        {
            if (infos.Count > 5
                && infos[0] != null
                && infos[0] is int
                && infos[1] != null
                && infos[1] is string
                && infos[2] != null
                && infos[2] is string
                && infos[3] != null
                && infos[3] is string
                && infos[4] != null
                && infos[4] is string
                && infos[5] != null
                && infos[5] is int)
            {
                ConnectionID = (int)infos[0];
                DestinationID = infos[1] as string;
                Direction = infos[2] as string;
                Transport = infos[3] as string;
                Topic = infos[4] as string;
                Connected = (int)infos[5];
            }
            if (infos.Count > 6
                && infos[6] != null
                && infos[6] is string)
            {
                Msg = infos[6] as string;
            }
        }
    }
}