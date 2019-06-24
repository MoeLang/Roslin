namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/SpeedMode", "69d5c38e10a2546093c0ed4d98df906b", @"# Speed Control Message with Mode
# Contains speed commands and desired autonomy active mode flag

std_msgs/Header header

uint16 mode # Is 1 if autonomy mode should be active

float32 speed                # Desired speed (m/sec)
float32 acceleration_limit   # Max acceleration limit (m/sec^2)
float32 deceleration_limit   # Max deceleration limit (m/sec^2)

")]
    public partial class SpeedMode : RosMsg
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

        public System.Single speed
        {
            get;
            set;
        }

        public System.Single acceleration_limit
        {
            get;
            set;
        }

        public System.Single deceleration_limit
        {
            get;
            set;
        }

        public SpeedMode(): base()
        {
        }

        public SpeedMode(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(mode);
            binaryWriter.Write(speed);
            binaryWriter.Write(acceleration_limit);
            binaryWriter.Write(deceleration_limit);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            mode = binaryReader.ReadUInt16();
            speed = binaryReader.ReadSingle();
            acceleration_limit = binaryReader.ReadSingle();
            deceleration_limit = binaryReader.ReadSingle();
        }
    }
}