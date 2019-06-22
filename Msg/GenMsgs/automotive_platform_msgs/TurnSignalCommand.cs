namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/TurnSignalCommand", "dfcc072c40d13a25c7a88dcc60473ed5", "# Turn Signal Command with Mode\n# Contains turn signal command and desired autonomy active mode flag\n\nstd_msgs/Header header\n\nuint16 mode             # Is 1 if autonomy mode should be active\n\nuint8 NONE=0\nuint8 LEFT=1\nuint8 RIGHT=2\nuint8 turn_signal       # Desired turn signal on\n\n\n")]
    public partial class TurnSignalCommand : RosMsg
    {
        public System.Byte NONE => 0;
        public System.Byte LEFT => 1;
        public System.Byte RIGHT => 2;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt16 mode
        {
            get;
            set;
        }

        public System.Byte turn_signal
        {
            get;
            set;
        }

        public TurnSignalCommand(): base()
        {
        }

        public TurnSignalCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(mode);
            binaryWriter.Write(turn_signal);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            mode = binaryReader.ReadUInt16();
            turn_signal = binaryReader.ReadByte();
        }
    }
}