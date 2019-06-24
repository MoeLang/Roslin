namespace Roslin.Msg.jsk_footstep_msgs
{
    [MsgInfo("jsk_footstep_msgs/ExecFootstepsAction", "c92f25369ce56498a9f7b060b84a87e6", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

ExecFootstepsActionGoal action_goal
ExecFootstepsActionResult action_result
ExecFootstepsActionFeedback action_feedback
")]
    public partial class ExecFootstepsAction : RosMsg
    {
        public ExecFootstepsActionGoal action_goal
        {
            get;
            set;
        }

        public ExecFootstepsActionResult action_result
        {
            get;
            set;
        }

        public ExecFootstepsActionFeedback action_feedback
        {
            get;
            set;
        }

        public ExecFootstepsAction(): base()
        {
        }

        public ExecFootstepsAction(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            action_goal = new ExecFootstepsActionGoal(binaryReader);
            action_result = new ExecFootstepsActionResult(binaryReader);
            action_feedback = new ExecFootstepsActionFeedback(binaryReader);
        }
    }
}