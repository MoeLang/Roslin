namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SteerSystemCmd", "cfa0df9428e1c56b79ca986e115663f7", @"Header header

bool enable
bool ignore_overrides
bool clear_override
bool clear_faults

float64 command
float64 rotation_rate
")]
    public partial class SteerSystemCmd : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean enable
        {
            get;
            set;
        }

        public System.Boolean ignore_overrides
        {
            get;
            set;
        }

        public System.Boolean clear_override
        {
            get;
            set;
        }

        public System.Boolean clear_faults
        {
            get;
            set;
        }

        public System.Double command
        {
            get;
            set;
        }

        public System.Double rotation_rate
        {
            get;
            set;
        }

        public SteerSystemCmd(): base()
        {
        }

        public SteerSystemCmd(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(enable);
            binaryWriter.Write(ignore_overrides);
            binaryWriter.Write(clear_override);
            binaryWriter.Write(clear_faults);
            binaryWriter.Write(command);
            binaryWriter.Write(rotation_rate);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            enable = binaryReader.ReadBoolean();
            ignore_overrides = binaryReader.ReadBoolean();
            clear_override = binaryReader.ReadBoolean();
            clear_faults = binaryReader.ReadBoolean();
            command = binaryReader.ReadDouble();
            rotation_rate = binaryReader.ReadDouble();
        }
    }
}