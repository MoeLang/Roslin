namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/SteerMode", "33a61f06ffb4d9f43cbb08ac344d667b", "# Steering Control Message with Mode\n# Contains steering commands and desired autonomy active mode flag\n\nstd_msgs/Header header\n\nuint16 mode # Is 1 if autonomy mode should be active\n\nfloat32 curvature           # Desired steering curvature (1/m)\nfloat32 max_curvature_rate  # Max rate of change for curvature (1/m/sec)\n\n\n")]
    public partial class SteerMode : RosMsg
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

        public System.Single curvature
        {
            get;
            set;
        }

        public System.Single max_curvature_rate
        {
            get;
            set;
        }

        public SteerMode(): base()
        {
        }

        public SteerMode(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(mode);
            binaryWriter.Write(curvature);
            binaryWriter.Write(max_curvature_rate);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            mode = binaryReader.ReadUInt16();
            curvature = binaryReader.ReadSingle();
            max_curvature_rate = binaryReader.ReadSingle();
        }
    }
}