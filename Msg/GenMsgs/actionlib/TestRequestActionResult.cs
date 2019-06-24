namespace Roslin.Msg.actionlib
{
    [MsgInfo("actionlib/TestRequestActionResult", "0476d1fdf437a3a6e7d6d0e9f5561298", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

Header header
actionlib_msgs/GoalStatus status
TestRequestResult result
")]
    public partial class TestRequestActionResult : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public actionlib_msgs.GoalStatus status
        {
            get;
            set;
        }

        public TestRequestResult result
        {
            get;
            set;
        }

        public TestRequestActionResult(): base()
        {
        }

        public TestRequestActionResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            status.Serilize(binaryWriter);
            result.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            status = new actionlib_msgs.GoalStatus(binaryReader);
            result = new TestRequestResult(binaryReader);
        }
    }
}