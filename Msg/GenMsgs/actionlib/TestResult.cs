namespace Roslin.Msg.actionlib
{
    [MsgInfo("actionlib/TestResult", "034a8e20d6a306665e3a5b340fab3f09", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\nint32 result\n")]
    public partial class TestResult : RosMsg
    {
        public System.Int32 result
        {
            get;
            set;
        }

        public TestResult(): base()
        {
        }

        public TestResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(result);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            result = binaryReader.ReadInt32();
        }
    }
}