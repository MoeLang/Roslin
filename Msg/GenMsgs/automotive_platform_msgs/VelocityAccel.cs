namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/VelocityAccel", "f9f86d6cc8bf87a22c9bcce69cd571b2", "# Vehicle Lateral Velocity and Acceleration Message\n\nstd_msgs/Header header\n\nfloat32 velocity     # meters/sec\nfloat32 accleration  # meters/sec^2\n\n")]
    public partial class VelocityAccel : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single velocity
        {
            get;
            set;
        }

        public System.Single accleration
        {
            get;
            set;
        }

        public VelocityAccel(): base()
        {
        }

        public VelocityAccel(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(velocity);
            binaryWriter.Write(accleration);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            velocity = binaryReader.ReadSingle();
            accleration = binaryReader.ReadSingle();
        }
    }
}