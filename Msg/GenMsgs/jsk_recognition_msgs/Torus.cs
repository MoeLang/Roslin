namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Torus", "7172d433485e406ce56f4cf6e9ab1062", "Header header\nbool failure\ngeometry_msgs/Pose pose\nfloat64 large_radius\nfloat64 small_radius\n")]
    public partial class Torus : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean failure
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public System.Double large_radius
        {
            get;
            set;
        }

        public System.Double small_radius
        {
            get;
            set;
        }

        public Torus(): base()
        {
        }

        public Torus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(failure);
            pose.Serilize(binaryWriter);
            binaryWriter.Write(large_radius);
            binaryWriter.Write(small_radius);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            failure = binaryReader.ReadBoolean();
            pose = new geometry_msgs.Pose(binaryReader);
            large_radius = binaryReader.ReadDouble();
            small_radius = binaryReader.ReadDouble();
        }
    }
}