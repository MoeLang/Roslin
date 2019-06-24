namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/BlindSpotIndicators", "a39bfc831de5c58751c4df286437dc15", @"# Blind Spot Indicators Active
# True if system is enabled and something is detected in the blind spot

std_msgs/Header header

bool left
bool right


")]
    public partial class BlindSpotIndicators : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean left
        {
            get;
            set;
        }

        public System.Boolean right
        {
            get;
            set;
        }

        public BlindSpotIndicators(): base()
        {
        }

        public BlindSpotIndicators(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(left);
            binaryWriter.Write(right);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            left = binaryReader.ReadBoolean();
            right = binaryReader.ReadBoolean();
        }
    }
}