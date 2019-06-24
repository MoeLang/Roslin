namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SegmentStamped", "1f2fbdf9b9a242110bee5312e7718d1f", @"Header header
Segment segment
")]
    public partial class SegmentStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Segment segment
        {
            get;
            set;
        }

        public SegmentStamped(): base()
        {
        }

        public SegmentStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            segment.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            segment = new Segment(binaryReader);
        }
    }
}