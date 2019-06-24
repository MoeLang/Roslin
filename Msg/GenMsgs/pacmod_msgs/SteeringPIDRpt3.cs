namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SteeringPIDRpt3", "722f63b47fd2935245656ab58fbec284", @"Header header

float64 new_torque         
float64 str_angle_desired  
float64 str_angle_actual         
float64 error
")]
    public partial class SteeringPIDRpt3 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double new_torque
        {
            get;
            set;
        }

        public System.Double str_angle_desired
        {
            get;
            set;
        }

        public System.Double str_angle_actual
        {
            get;
            set;
        }

        public System.Double error
        {
            get;
            set;
        }

        public SteeringPIDRpt3(): base()
        {
        }

        public SteeringPIDRpt3(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(new_torque);
            binaryWriter.Write(str_angle_desired);
            binaryWriter.Write(str_angle_actual);
            binaryWriter.Write(error);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            new_torque = binaryReader.ReadDouble();
            str_angle_desired = binaryReader.ReadDouble();
            str_angle_actual = binaryReader.ReadDouble();
            error = binaryReader.ReadDouble();
        }
    }
}