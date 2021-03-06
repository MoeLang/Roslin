namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/JointControllerState", "987ad85e4756f3aef7f1e5e7fe0595d1", @"Header header
float64 set_point
float64 process_value
float64 process_value_dot
float64 error
float64 time_step
float64 command
float64 p
float64 i
float64 d
float64 i_clamp
bool antiwindup
")]
    public partial class JointControllerState : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double set_point
        {
            get;
            set;
        }

        public System.Double process_value
        {
            get;
            set;
        }

        public System.Double process_value_dot
        {
            get;
            set;
        }

        public System.Double error
        {
            get;
            set;
        }

        public System.Double time_step
        {
            get;
            set;
        }

        public System.Double command
        {
            get;
            set;
        }

        public System.Double p
        {
            get;
            set;
        }

        public System.Double i
        {
            get;
            set;
        }

        public System.Double d
        {
            get;
            set;
        }

        public System.Double i_clamp
        {
            get;
            set;
        }

        public System.Boolean antiwindup
        {
            get;
            set;
        }

        public JointControllerState(): base()
        {
        }

        public JointControllerState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(set_point);
            binaryWriter.Write(process_value);
            binaryWriter.Write(process_value_dot);
            binaryWriter.Write(error);
            binaryWriter.Write(time_step);
            binaryWriter.Write(command);
            binaryWriter.Write(p);
            binaryWriter.Write(i);
            binaryWriter.Write(d);
            binaryWriter.Write(i_clamp);
            binaryWriter.Write(antiwindup);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            set_point = binaryReader.ReadDouble();
            process_value = binaryReader.ReadDouble();
            process_value_dot = binaryReader.ReadDouble();
            error = binaryReader.ReadDouble();
            time_step = binaryReader.ReadDouble();
            command = binaryReader.ReadDouble();
            p = binaryReader.ReadDouble();
            i = binaryReader.ReadDouble();
            d = binaryReader.ReadDouble();
            i_clamp = binaryReader.ReadDouble();
            antiwindup = binaryReader.ReadBoolean();
        }
    }
}