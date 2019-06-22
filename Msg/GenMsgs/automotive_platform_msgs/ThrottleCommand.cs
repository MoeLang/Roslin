namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/ThrottleCommand", "e5121b671d09b4686521aac007acd4bd", "# Current Throttle Pedal Command\n\nstd_msgs/Header header\n\nfloat32 throttle_pedal     # 0 to 1.0\n\n\n")]
    public partial class ThrottleCommand : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single throttle_pedal
        {
            get;
            set;
        }

        public ThrottleCommand(): base()
        {
        }

        public ThrottleCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(throttle_pedal);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            throttle_pedal = binaryReader.ReadSingle();
        }
    }
}