namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Int16", "8524586e34fbd7cb1c08c5f5f1ca0e57", @"int16 data
")]
    public partial class Int16 : RosMsg
    {
        public System.Int16 data
        {
            get;
            set;
        }

        public Int16(): base()
        {
        }

        public Int16(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadInt16();
        }
    }
}