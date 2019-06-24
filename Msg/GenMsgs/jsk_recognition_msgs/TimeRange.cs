namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/TimeRange", "a8a69e1e51e3731790c8e4120a725398", @"# Represents range of time.
std_msgs/Header header
time start
time end
")]
    public partial class TimeRange : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.DateTime start
        {
            get;
            set;
        }

        public System.DateTime end
        {
            get;
            set;
        }

        public TimeRange(): base()
        {
        }

        public TimeRange(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(start);
            binaryWriter.Write(end);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            start = binaryReader.ReadDateTime();
            end = binaryReader.ReadDateTime();
        }
    }
}