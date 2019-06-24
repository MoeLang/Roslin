namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SimpleHandle", "3a87e21f72b9ed7090c46a47617b0740", @"Header header
geometry_msgs/Pose pose
float64 handle_width
")]
    public partial class SimpleHandle : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public System.Double handle_width
        {
            get;
            set;
        }

        public SimpleHandle(): base()
        {
        }

        public SimpleHandle(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            pose.Serilize(binaryWriter);
            binaryWriter.Write(handle_width);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            pose = new geometry_msgs.Pose(binaryReader);
            handle_width = binaryReader.ReadDouble();
        }
    }
}