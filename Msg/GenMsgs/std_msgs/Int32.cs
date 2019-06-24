namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Int32", "da5909fbe378aeaf85e547e830cc1bb7", @"int32 data")]
    public partial class Int32 : RosMsg
    {
        public System.Int32 data
        {
            get;
            set;
        }

        public Int32(): base()
        {
        }

        public Int32(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadInt32();
        }
    }
}