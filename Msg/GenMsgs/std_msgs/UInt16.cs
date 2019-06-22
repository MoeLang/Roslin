namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/UInt16", "1df79edf208b629fe6b81923a544552d", "uint16 data\n")]
    public partial class UInt16 : RosMsg
    {
        public System.UInt16 data
        {
            get;
            set;
        }

        public UInt16(): base()
        {
        }

        public UInt16(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadUInt16();
        }
    }
}