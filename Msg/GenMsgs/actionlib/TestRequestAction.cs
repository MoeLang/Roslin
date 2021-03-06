namespace Roslin.Msg.actionlib
{
    [MsgInfo("actionlib/TestRequestAction", "dc44b1f4045dbf0d1db54423b3b86b30", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

TestRequestActionGoal action_goal
TestRequestActionResult action_result
TestRequestActionFeedback action_feedback
")]
    public partial class TestRequestAction : RosMsg
    {
        public TestRequestActionGoal action_goal
        {
            get;
            set;
        }

        public TestRequestActionResult action_result
        {
            get;
            set;
        }

        public TestRequestActionFeedback action_feedback
        {
            get;
            set;
        }

        public TestRequestAction(): base()
        {
        }

        public TestRequestAction(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            action_goal.Serilize(binaryWriter);
            action_result.Serilize(binaryWriter);
            action_feedback.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            action_goal = new TestRequestActionGoal(binaryReader);
            action_result = new TestRequestActionResult(binaryReader);
            action_feedback = new TestRequestActionFeedback(binaryReader);
        }
    }
}