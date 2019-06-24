namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/VelocityAccelCov", "442ea8ec9a8f9da3a9592bdc06dc6731", @"# Vehicle Lateral Velocity and Acceleration Message with Covariance

std_msgs/Header header

float32 velocity     # meters/sec
float32 accleration  # meters/sec^2
float32 covariance   # (meters/sec)^2
")]
    public partial class VelocityAccelCov : RosMsg
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

        public System.Single covariance
        {
            get;
            set;
        }

        public VelocityAccelCov(): base()
        {
        }

        public VelocityAccelCov(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(velocity);
            binaryWriter.Write(accleration);
            binaryWriter.Write(covariance);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            velocity = binaryReader.ReadSingle();
            accleration = binaryReader.ReadSingle();
            covariance = binaryReader.ReadSingle();
        }
    }
}