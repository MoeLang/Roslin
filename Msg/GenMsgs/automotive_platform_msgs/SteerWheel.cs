namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/SteerWheel", "3c61b8a39f0555662752d160f35b72c0", "# Steering Wheel Control Message with Mode\n# Contains steering wheel command and desired autonomy active mode flag\n\nstd_msgs/Header header\n\nuint16 mode             # Is 1 if autonomy mode should be active\n\nfloat32 angle           # Desired steering wheel angle (rad)\nfloat32 angle_velocity  # Desired steering wheel angle max velocity (rad/sec)\n\n\n")]
    public partial class SteerWheel : RosMsg
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

        public System.Single angle
        {
            get;
            set;
        }

        public System.Single angle_velocity
        {
            get;
            set;
        }

        public SteerWheel(): base()
        {
        }

        public SteerWheel(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(mode);
            binaryWriter.Write(angle);
            binaryWriter.Write(angle_velocity);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            mode = binaryReader.ReadUInt16();
            angle = binaryReader.ReadSingle();
            angle_velocity = binaryReader.ReadSingle();
        }
    }
}