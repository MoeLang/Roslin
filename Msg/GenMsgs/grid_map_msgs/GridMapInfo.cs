namespace Roslin.Msg.grid_map_msgs
{
    [MsgInfo("grid_map_msgs/GridMapInfo", "43ee5430e1c253682111cb6bedac0ef9", @"# Header (time and frame)
Header header

# Resolution of the grid [m/cell].
float64 resolution

# Length in x-direction [m].
float64 length_x

# Length in y-direction [m].
float64 length_y

# Pose of the grid map center in the frame defined in `header` [m].
geometry_msgs/Pose pose")]
    public partial class GridMapInfo : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double resolution
        {
            get;
            set;
        }

        public System.Double length_x
        {
            get;
            set;
        }

        public System.Double length_y
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public GridMapInfo(): base()
        {
        }

        public GridMapInfo(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(resolution);
            binaryWriter.Write(length_x);
            binaryWriter.Write(length_y);
            pose.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            resolution = binaryReader.ReadDouble();
            length_x = binaryReader.ReadDouble();
            length_y = binaryReader.ReadDouble();
            pose = new geometry_msgs.Pose(binaryReader);
        }
    }
}