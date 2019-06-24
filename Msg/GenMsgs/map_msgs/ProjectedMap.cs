namespace Roslin.Msg.map_msgs
{
    [MsgInfo("map_msgs/ProjectedMap", "7bbe8f96e45089681dc1ea7d023cbfca", @"nav_msgs/OccupancyGrid map
float64 min_z
float64 max_z")]
    public partial class ProjectedMap : RosMsg
    {
        public nav_msgs.OccupancyGrid map
        {
            get;
            set;
        }

        public System.Double min_z
        {
            get;
            set;
        }

        public System.Double max_z
        {
            get;
            set;
        }

        public ProjectedMap(): base()
        {
        }

        public ProjectedMap(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            map.Serilize(binaryWriter);
            binaryWriter.Write(min_z);
            binaryWriter.Write(max_z);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            map = new nav_msgs.OccupancyGrid(binaryReader);
            min_z = binaryReader.ReadDouble();
            max_z = binaryReader.ReadDouble();
        }
    }
}