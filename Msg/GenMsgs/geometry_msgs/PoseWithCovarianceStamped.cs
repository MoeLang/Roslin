namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/PoseWithCovarianceStamped", "953b798c0f514ff060a53a3498ce6246", @"# This expresses an estimated pose with a reference coordinate frame and timestamp

Header header
PoseWithCovariance pose
")]
    public partial class PoseWithCovarianceStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public PoseWithCovariance pose
        {
            get;
            set;
        }

        public PoseWithCovarianceStamped(): base()
        {
        }

        public PoseWithCovarianceStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            pose = new PoseWithCovariance(binaryReader);
        }
    }
}