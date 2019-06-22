namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/PositionWithSpeed", "7e96a8c8cbc8234d4d2c87880ddb7cfe", "Header header\n\nfloat64 angular_position                # The desired rotational position of the motor shaft about it's z axis in Radians\nfloat64 angular_velocity_limit          # The desired speed limit to acheive the desired position in Radians/second (z axis)\n")]
    public partial class PositionWithSpeed : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double angular_position
        {
            get;
            set;
        }

        public System.Double angular_velocity_limit
        {
            get;
            set;
        }

        public PositionWithSpeed(): base()
        {
        }

        public PositionWithSpeed(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(angular_position);
            binaryWriter.Write(angular_velocity_limit);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            angular_position = binaryReader.ReadDouble();
            angular_velocity_limit = binaryReader.ReadDouble();
        }
    }
}