namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/RoadNetworkBoundaries", "1401bcf0d0f7367848bb50e6ad210a4b", "# Road Network Boundaries Array Message\n# Contains an array of lane boundary arrays forming a map/road network\n\nstd_msgs/Header header\n\nautomotive_navigation_msgs/LaneBoundaryArray[] road_network_boundaries\n\n")]
    public partial class RoadNetworkBoundaries : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public automotive_navigation_msgs.LaneBoundaryArray[] road_network_boundaries
        {
            get;
            set;
        }

        public RoadNetworkBoundaries(): base()
        {
        }

        public RoadNetworkBoundaries(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(road_network_boundaries.Length); for  ( int  i  =  0 ;  i < road_network_boundaries . Length ;  i ++ ) road_network_boundaries [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            road_network_boundaries = new automotive_navigation_msgs.LaneBoundaryArray[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < road_network_boundaries . Length ;  i ++ ) road_network_boundaries [ i ]  =  new  automotive_navigation_msgs . LaneBoundaryArray ( binaryReader ) ; 
        }
    }
}