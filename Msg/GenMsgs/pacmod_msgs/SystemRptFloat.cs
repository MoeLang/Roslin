namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SystemRptFloat", "e3af53d7d085bbad777634bcc2681141", "Header header\n\nbool enabled\nbool override_active\nbool command_output_fault\nbool input_output_fault\nbool output_reported_fault\nbool pacmod_fault\nbool vehicle_fault\n\nfloat64 manual_input\nfloat64 command\nfloat64 output\n")]
    public partial class SystemRptFloat : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean enabled
        {
            get;
            set;
        }

        public System.Boolean override_active
        {
            get;
            set;
        }

        public System.Boolean command_output_fault
        {
            get;
            set;
        }

        public System.Boolean input_output_fault
        {
            get;
            set;
        }

        public System.Boolean output_reported_fault
        {
            get;
            set;
        }

        public System.Boolean pacmod_fault
        {
            get;
            set;
        }

        public System.Boolean vehicle_fault
        {
            get;
            set;
        }

        public System.Double manual_input
        {
            get;
            set;
        }

        public System.Double command
        {
            get;
            set;
        }

        public System.Double output
        {
            get;
            set;
        }

        public SystemRptFloat(): base()
        {
        }

        public SystemRptFloat(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(enabled);
            binaryWriter.Write(override_active);
            binaryWriter.Write(command_output_fault);
            binaryWriter.Write(input_output_fault);
            binaryWriter.Write(output_reported_fault);
            binaryWriter.Write(pacmod_fault);
            binaryWriter.Write(vehicle_fault);
            binaryWriter.Write(manual_input);
            binaryWriter.Write(command);
            binaryWriter.Write(output);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            enabled = binaryReader.ReadBoolean();
            override_active = binaryReader.ReadBoolean();
            command_output_fault = binaryReader.ReadBoolean();
            input_output_fault = binaryReader.ReadBoolean();
            output_reported_fault = binaryReader.ReadBoolean();
            pacmod_fault = binaryReader.ReadBoolean();
            vehicle_fault = binaryReader.ReadBoolean();
            manual_input = binaryReader.ReadDouble();
            command = binaryReader.ReadDouble();
            output = binaryReader.ReadDouble();
        }
    }
}