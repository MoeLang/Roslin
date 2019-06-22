namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/PointHeadAction", "7252920f1243de1b741f14f214125371", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nPointHeadActionGoal action_goal\nPointHeadActionResult action_result\nPointHeadActionFeedback action_feedback\n")]
    public partial class PointHeadAction : RosMsg
    {
        public PointHeadActionGoal action_goal
        {
            get;
            set;
        }

        public PointHeadActionResult action_result
        {
            get;
            set;
        }

        public PointHeadActionFeedback action_feedback
        {
            get;
            set;
        }

        public PointHeadAction(): base()
        {
        }

        public PointHeadAction(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            action_goal = new PointHeadActionGoal(binaryReader);
            action_result = new PointHeadActionResult(binaryReader);
            action_feedback = new PointHeadActionFeedback(binaryReader);
        }
    }
}