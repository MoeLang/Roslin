namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/MotorRpt2", "d757953b36f8ffe8db6389da9ff787a1", "Header header\n\nfloat64 encoder_temp        # Encoder temperature in degrees Celsius\nfloat64 motor_temp          # Internal motor temperature in degrees Celsius\nfloat64 angular_velocity    # Angular velocity of the motor shaft (z axis) in Radians/second\n")]
    public partial class MotorRpt2 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double encoder_temp
        {
            get;
            set;
        }

        public System.Double motor_temp
        {
            get;
            set;
        }

        public System.Double angular_velocity
        {
            get;
            set;
        }

        public MotorRpt2(): base()
        {
        }

        public MotorRpt2(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(encoder_temp);
            binaryWriter.Write(motor_temp);
            binaryWriter.Write(angular_velocity);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            encoder_temp = binaryReader.ReadDouble();
            motor_temp = binaryReader.ReadDouble();
            angular_velocity = binaryReader.ReadDouble();
        }
    }
}