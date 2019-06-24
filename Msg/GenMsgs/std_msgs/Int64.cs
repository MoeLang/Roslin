namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Int64", "34add168574510e6e17f5d23ecc077ef", @"int64 data")]
    public partial class Int64 : RosMsg
    {
        public System.Int64 data
        {
            get;
            set;
        }

        public Int64(): base()
        {
        }

        public Int64(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadInt64();
        }
    }
}