namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/WheelSpeedRpt", "0ade552ffaaff87eca01c4d9b49bb8ae", @"Header header

float64 front_left_wheel_speed
float64 front_right_wheel_speed
float64 rear_left_wheel_speed
float64 rear_right_wheel_speed

")]
    public partial class WheelSpeedRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double front_left_wheel_speed
        {
            get;
            set;
        }

        public System.Double front_right_wheel_speed
        {
            get;
            set;
        }

        public System.Double rear_left_wheel_speed
        {
            get;
            set;
        }

        public System.Double rear_right_wheel_speed
        {
            get;
            set;
        }

        public WheelSpeedRpt(): base()
        {
        }

        public WheelSpeedRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(front_left_wheel_speed);
            binaryWriter.Write(front_right_wheel_speed);
            binaryWriter.Write(rear_left_wheel_speed);
            binaryWriter.Write(rear_right_wheel_speed);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            front_left_wheel_speed = binaryReader.ReadDouble();
            front_right_wheel_speed = binaryReader.ReadDouble();
            rear_left_wheel_speed = binaryReader.ReadDouble();
            rear_right_wheel_speed = binaryReader.ReadDouble();
        }
    }
}