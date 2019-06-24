namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Segment", "0125c553546d7123dccaeab992a9e29e", @"geometry_msgs/Point start_point
geometry_msgs/Point end_point
")]
    public partial class Segment : RosMsg
    {
        public geometry_msgs.Point start_point
        {
            get;
            set;
        }

        public geometry_msgs.Point end_point
        {
            get;
            set;
        }

        public Segment(): base()
        {
        }

        public Segment(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            start_point.Serilize(binaryWriter);
            end_point.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            start_point = new geometry_msgs.Point(binaryReader);
            end_point = new geometry_msgs.Point(binaryReader);
        }
    }
}