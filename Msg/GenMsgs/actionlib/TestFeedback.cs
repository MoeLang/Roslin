namespace Roslin.Msg.actionlib
{
    [MsgInfo("actionlib/TestFeedback", "49ceb5b32ea3af22073ede4a0328249e", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
int32 feedback

")]
    public partial class TestFeedback : RosMsg
    {
        public System.Int32 feedback
        {
            get;
            set;
        }

        public TestFeedback(): base()
        {
        }

        public TestFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(feedback);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            feedback = binaryReader.ReadInt32();
        }
    }
}