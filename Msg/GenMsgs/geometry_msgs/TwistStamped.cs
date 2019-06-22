namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/TwistStamped", "98d34b0043a2093cf9d9345ab6eef12e", "# A twist with reference coordinate frame and timestamp\nHeader header\nTwist twist\n")]
    public partial class TwistStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Twist twist
        {
            get;
            set;
        }

        public TwistStamped(): base()
        {
        }

        public TwistStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            twist = new Twist(binaryReader);
        }
    }
}