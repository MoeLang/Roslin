namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Byte", "ad736a2e8818154c487bb80fe42ce43b", @"byte data
")]
    public partial class Byte : RosMsg
    {
        public System.Byte data
        {
            get;
            set;
        }

        public Byte(): base()
        {
        }

        public Byte(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadByte();
        }
    }
}