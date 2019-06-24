namespace Roslin.Msg.turtlesim
{
    [MsgInfo("turtlesim/Pose", "863b248d5016ca62ea2e895ae5265cf9", @"float32 x
float32 y
float32 theta

float32 linear_velocity
float32 angular_velocity")]
    public partial class Pose : RosMsg
    {
        public System.Single x
        {
            get;
            set;
        }

        public System.Single y
        {
            get;
            set;
        }

        public System.Single theta
        {
            get;
            set;
        }

        public System.Single linear_velocity
        {
            get;
            set;
        }

        public System.Single angular_velocity
        {
            get;
            set;
        }

        public Pose(): base()
        {
        }

        public Pose(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(theta);
            binaryWriter.Write(linear_velocity);
            binaryWriter.Write(angular_velocity);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            x = binaryReader.ReadSingle();
            y = binaryReader.ReadSingle();
            theta = binaryReader.ReadSingle();
            linear_velocity = binaryReader.ReadSingle();
            angular_velocity = binaryReader.ReadSingle();
        }
    }
}