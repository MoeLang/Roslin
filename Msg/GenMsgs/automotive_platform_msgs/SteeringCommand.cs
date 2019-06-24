namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/SteeringCommand", "f61fd13efbfee4ea479942d1f6acebc4", @"# Current Steering Wheel Angle Command

std_msgs/Header header

float32 steering_wheel_angle     # Radians


")]
    public partial class SteeringCommand : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single steering_wheel_angle
        {
            get;
            set;
        }

        public SteeringCommand(): base()
        {
        }

        public SteeringCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(steering_wheel_angle);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            steering_wheel_angle = binaryReader.ReadSingle();
        }
    }
}