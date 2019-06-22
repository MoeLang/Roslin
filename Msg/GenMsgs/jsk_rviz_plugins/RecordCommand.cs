namespace Roslin.Msg.jsk_rviz_plugins
{
    [MsgInfo("jsk_rviz_plugins/RecordCommand", "31931c62eab5500089183eef0161c139", "uint8 RECORD=0\nuint8 RECORD_STOP=1\nuint8 PLAY=2\n\nint8 command\nstring target")]
    public partial class RecordCommand : RosMsg
    {
        public System.Byte RECORD => 0;
        public System.Byte RECORD_STOP => 1;
        public System.Byte PLAY => 2;
        public System.SByte command
        {
            get;
            set;
        }

        public System.String target
        {
            get;
            set;
        }

        public RecordCommand(): base()
        {
        }

        public RecordCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(command);
            binaryWriter.Write(target.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( target ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            command = binaryReader.ReadSByte();
            target = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}