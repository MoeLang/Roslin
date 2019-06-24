namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/UInt8", "7c8164229e7d2c17eb95e9231617fdee", @"uint8 data
")]
    public partial class UInt8 : RosMsg
    {
        public System.Byte data
        {
            get;
            set;
        }

        public UInt8(): base()
        {
        }

        public UInt8(System.IO.BinaryReader binaryReader): base(binaryReader)
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