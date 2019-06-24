namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/SpeedPedals", "85ba8dc36f9790f861deedfe03109b15", @"# Speed Pedals Control Message with Mode
# Contains throttle and brake commands and desired autonomy active mode flag

std_msgs/Header header

uint16 mode # Is 1 if autonomy mode should be active

float32 throttle       # 0 to 1 percent
float32 brake          # 0 to 1 percent

")]
    public partial class SpeedPedals : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt16 mode
        {
            get;
            set;
        }

        public System.Single throttle
        {
            get;
            set;
        }

        public System.Single brake
        {
            get;
            set;
        }

        public SpeedPedals(): base()
        {
        }

        public SpeedPedals(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(mode);
            binaryWriter.Write(throttle);
            binaryWriter.Write(brake);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            mode = binaryReader.ReadUInt16();
            throttle = binaryReader.ReadSingle();
            brake = binaryReader.ReadSingle();
        }
    }
}