namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/TwistWithCovarianceStamped", "8927a1a12fb2607ceea095b2dc440a96", @"# This represents an estimated twist with reference coordinate frame and timestamp.
Header header
TwistWithCovariance twist
")]
    public partial class TwistWithCovarianceStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public TwistWithCovariance twist
        {
            get;
            set;
        }

        public TwistWithCovarianceStamped(): base()
        {
        }

        public TwistWithCovarianceStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            twist.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            twist = new TwistWithCovariance(binaryReader);
        }
    }
}