namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/PoseStamped", "d3812c3cbc69362b77dc0b19b345f8f5", "# A Pose with reference coordinate frame and timestamp\nHeader header\nPose pose\n")]
    public partial class PoseStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Pose pose
        {
            get;
            set;
        }

        public PoseStamped(): base()
        {
        }

        public PoseStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            pose.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            pose = new Pose(binaryReader);
        }
    }
}