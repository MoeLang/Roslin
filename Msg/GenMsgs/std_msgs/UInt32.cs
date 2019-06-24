namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/UInt32", "304a39449588c7f8ce2df6e8001c5fce", @"uint32 data")]
    public partial class UInt32 : RosMsg
    {
        public System.UInt32 data
        {
            get;
            set;
        }

        public UInt32(): base()
        {
        }

        public UInt32(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadUInt32();
        }
    }
}