namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/RotatedRectStamped", "0260299b5425567e14c7b295b58829e9", @"Header header
RotatedRect rect
")]
    public partial class RotatedRectStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public RotatedRect rect
        {
            get;
            set;
        }

        public RotatedRectStamped(): base()
        {
        }

        public RotatedRectStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            rect.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            rect = new RotatedRect(binaryReader);
        }
    }
}