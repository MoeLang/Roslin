namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SteeringPIDRpt4", "2bc4404ec9df7da4ed993a2081a68002", "Header header\n\nfloat64 angular_velocity         \nfloat64 angular_acceleration\n\n")]
    public partial class SteeringPIDRpt4 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double angular_velocity
        {
            get;
            set;
        }

        public System.Double angular_acceleration
        {
            get;
            set;
        }

        public SteeringPIDRpt4(): base()
        {
        }

        public SteeringPIDRpt4(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(angular_velocity);
            binaryWriter.Write(angular_acceleration);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            angular_velocity = binaryReader.ReadDouble();
            angular_acceleration = binaryReader.ReadDouble();
        }
    }
}