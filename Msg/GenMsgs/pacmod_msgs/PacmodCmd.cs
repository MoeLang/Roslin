namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/PacmodCmd", "c4197651090f1dbf0dfef39c46c42bea", "Header header\n\nfloat64 f64_cmd\nuint16 ui16_cmd\nbool enable\nbool clear\nbool ignore\n\nuint16 TURN_RIGHT = 0\nuint16 TURN_NONE = 1\nuint16 TURN_LEFT = 2\n\nuint16 SHIFT_PARK = 0\nuint16 SHIFT_REVERSE = 1\nuint16 SHIFT_NEUTRAL = 2\nuint16 SHIFT_FORWARD = 3\nuint16 SHIFT_HIGH = 3 # For Polaris Ranger\nuint16 SHIFT_LOW = 4\n")]
    public partial class PacmodCmd : RosMsg
    {
        public System.UInt16 TURN_RIGHT => 0;
        public System.UInt16 TURN_NONE => 1;
        public System.UInt16 TURN_LEFT => 2;
        public System.UInt16 SHIFT_PARK => 0;
        public System.UInt16 SHIFT_REVERSE => 1;
        public System.UInt16 SHIFT_NEUTRAL => 2;
        public System.UInt16 SHIFT_FORWARD => 3;
        public System.UInt16 SHIFT_HIGH => 3;
        public System.UInt16 SHIFT_LOW => 4;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double f64_cmd
        {
            get;
            set;
        }

        public System.UInt16 ui16_cmd
        {
            get;
            set;
        }

        public System.Boolean enable
        {
            get;
            set;
        }

        public System.Boolean clear
        {
            get;
            set;
        }

        public System.Boolean ignore
        {
            get;
            set;
        }

        public PacmodCmd(): base()
        {
        }

        public PacmodCmd(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(f64_cmd);
            binaryWriter.Write(ui16_cmd);
            binaryWriter.Write(enable);
            binaryWriter.Write(clear);
            binaryWriter.Write(ignore);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            f64_cmd = binaryReader.ReadDouble();
            ui16_cmd = binaryReader.ReadUInt16();
            enable = binaryReader.ReadBoolean();
            clear = binaryReader.ReadBoolean();
            ignore = binaryReader.ReadBoolean();
        }
    }
}