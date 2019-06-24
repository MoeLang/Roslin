namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Int8", "27ffa0c9c4b8fb8492252bcad9e5c57b", @"int8 data
")]
    public partial class Int8 : RosMsg
    {
        public System.SByte data
        {
            get;
            set;
        }

        public Int8(): base()
        {
        }

        public Int8(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadSByte();
        }
    }
}