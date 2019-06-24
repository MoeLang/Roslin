namespace Roslin.Msg.jsk_topic_tools
{
    [MsgInfo("jsk_topic_tools/TopicInfo", "78edf14defd72c2fcd29e4fad0165ea9", @"string topic_name
float64 rate

")]
    public partial class TopicInfo : RosMsg
    {
        public System.String topic_name
        {
            get;
            set;
        }

        public System.Double rate
        {
            get;
            set;
        }

        public TopicInfo(): base()
        {
        }

        public TopicInfo(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(topic_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( topic_name ) ) ; 
            binaryWriter.Write(rate);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            topic_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            rate = binaryReader.ReadDouble();
        }
    }
}