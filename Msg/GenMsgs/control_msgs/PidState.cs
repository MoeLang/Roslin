namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/PidState", "b138ec00e886c10e73f27e8712252ea6", @"Header header
duration timestep
float64 error
float64 error_dot
float64 p_error
float64 i_error
float64 d_error
float64 p_term
float64 i_term
float64 d_term
float64 i_max
float64 i_min
float64 output
")]
    public partial class PidState : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.TimeSpan timestep
        {
            get;
            set;
        }

        public System.Double error
        {
            get;
            set;
        }

        public System.Double error_dot
        {
            get;
            set;
        }

        public System.Double p_error
        {
            get;
            set;
        }

        public System.Double i_error
        {
            get;
            set;
        }

        public System.Double d_error
        {
            get;
            set;
        }

        public System.Double p_term
        {
            get;
            set;
        }

        public System.Double i_term
        {
            get;
            set;
        }

        public System.Double d_term
        {
            get;
            set;
        }

        public System.Double i_max
        {
            get;
            set;
        }

        public System.Double i_min
        {
            get;
            set;
        }

        public System.Double output
        {
            get;
            set;
        }

        public PidState(): base()
        {
        }

        public PidState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(timestep);
            binaryWriter.Write(error);
            binaryWriter.Write(error_dot);
            binaryWriter.Write(p_error);
            binaryWriter.Write(i_error);
            binaryWriter.Write(d_error);
            binaryWriter.Write(p_term);
            binaryWriter.Write(i_term);
            binaryWriter.Write(d_term);
            binaryWriter.Write(i_max);
            binaryWriter.Write(i_min);
            binaryWriter.Write(output);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            timestep = binaryReader.ReadTimeSpan();
            error = binaryReader.ReadDouble();
            error_dot = binaryReader.ReadDouble();
            p_error = binaryReader.ReadDouble();
            i_error = binaryReader.ReadDouble();
            d_error = binaryReader.ReadDouble();
            p_term = binaryReader.ReadDouble();
            i_term = binaryReader.ReadDouble();
            d_term = binaryReader.ReadDouble();
            i_max = binaryReader.ReadDouble();
            i_min = binaryReader.ReadDouble();
            output = binaryReader.ReadDouble();
        }
    }
}