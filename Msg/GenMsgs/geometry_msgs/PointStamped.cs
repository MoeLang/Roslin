namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/PointStamped", "c63aecb41bfdfd6b7e1fac37c7cbe7bf", @"# This represents a Point with reference coordinate frame and timestamp
Header header
Point point
")]
    public partial class PointStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Point point
        {
            get;
            set;
        }

        public PointStamped(): base()
        {
        }

        public PointStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            point.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            point = new Point(binaryReader);
        }
    }
}