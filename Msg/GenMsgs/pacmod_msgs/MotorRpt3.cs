namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/MotorRpt3", "1640bb8a85b4353a76a6e6a5df503313", "Header header\n\nfloat64 torque_output   # Measured torque output of the motor in Newton-Meters\nfloat64 torque_input    # Measured torque input of the motor in Newton-Meters\n")]
    public partial class MotorRpt3 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double torque_output
        {
            get;
            set;
        }

        public System.Double torque_input
        {
            get;
            set;
        }

        public MotorRpt3(): base()
        {
        }

        public MotorRpt3(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(torque_output);
            binaryWriter.Write(torque_input);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            torque_output = binaryReader.ReadDouble();
            torque_input = binaryReader.ReadDouble();
        }
    }
}