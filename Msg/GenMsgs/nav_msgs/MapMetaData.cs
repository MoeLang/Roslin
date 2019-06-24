namespace Roslin.Msg.nav_msgs
{
    [MsgInfo("nav_msgs/MapMetaData", "10cfc8a2818024d3248802c00c95f11b", @"# This hold basic information about the characterists of the OccupancyGrid

# The time at which the map was loaded
time map_load_time
# The map resolution [m/cell]
float32 resolution
# Map width [cells]
uint32 width
# Map height [cells]
uint32 height
# The origin of the map [m, m, rad].  This is the real-world pose of the
# cell (0,0) in the map.
geometry_msgs/Pose origin")]
    public partial class MapMetaData : RosMsg
    {
        public System.DateTime map_load_time
        {
            get;
            set;
        }

        public System.Single resolution
        {
            get;
            set;
        }

        public System.UInt32 width
        {
            get;
            set;
        }

        public System.UInt32 height
        {
            get;
            set;
        }

        public geometry_msgs.Pose origin
        {
            get;
            set;
        }

        public MapMetaData(): base()
        {
        }

        public MapMetaData(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(map_load_time);
            binaryWriter.Write(resolution);
            binaryWriter.Write(width);
            binaryWriter.Write(height);
            origin.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            map_load_time = binaryReader.ReadDateTime();
            resolution = binaryReader.ReadSingle();
            width = binaryReader.ReadUInt32();
            height = binaryReader.ReadUInt32();
            origin = new geometry_msgs.Pose(binaryReader);
        }
    }
}