namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/HillStartAssist", "c17028b064a3857c9cf5363ecb14febb", @"# Hill Start Assist Active

std_msgs/Header header

bool active


")]
    public partial class HillStartAssist : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean active
        {
            get;
            set;
        }

        public HillStartAssist(): base()
        {
        }

        public HillStartAssist(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(active);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            active = binaryReader.ReadBoolean();
        }
    }
}