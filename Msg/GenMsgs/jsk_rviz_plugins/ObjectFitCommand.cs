namespace Roslin.Msg.jsk_rviz_plugins
{
    [MsgInfo("jsk_rviz_plugins/ObjectFitCommand", "aaf37eac6a6717d09d438978a4117776", "uint8 FIT=0\nuint8 NEAR=1\nuint8 OTHER=2\nuint8 REVERSE_FIT=3\nuint8 REVERSE_NEAR=4\nuint8 REVERSE_OTHER=5\n\nint8 command\n")]
    public partial class ObjectFitCommand : RosMsg
    {
        public System.Byte FIT => 0;
        public System.Byte NEAR => 1;
        public System.Byte OTHER => 2;
        public System.Byte REVERSE_FIT => 3;
        public System.Byte REVERSE_NEAR => 4;
        public System.Byte REVERSE_OTHER => 5;
        public System.SByte command
        {
            get;
            set;
        }

        public ObjectFitCommand(): base()
        {
        }

        public ObjectFitCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(command);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            command = binaryReader.ReadSByte();
        }
    }
}