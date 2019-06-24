namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/UInt64", "1b2a79973e8bf53d7b53acb71299cb57", @"uint64 data")]
    public partial class UInt64 : RosMsg
    {
        public System.UInt64 data
        {
            get;
            set;
        }

        public UInt64(): base()
        {
        }

        public UInt64(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadUInt64();
        }
    }
}