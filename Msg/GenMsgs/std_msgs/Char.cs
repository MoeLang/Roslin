namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Char", "1bf77f25acecdedba0e224b162199717", "char data")]
    public partial class Char : RosMsg
    {
        public System.Char data
        {
            get;
            set;
        }

        public Char(): base()
        {
        }

        public Char(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadChar();
        }
    }
}