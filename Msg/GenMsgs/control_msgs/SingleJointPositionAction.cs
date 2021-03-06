namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/SingleJointPositionAction", "c4a786b7d53e5d0983decf967a5a779e", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

SingleJointPositionActionGoal action_goal
SingleJointPositionActionResult action_result
SingleJointPositionActionFeedback action_feedback
")]
    public partial class SingleJointPositionAction : RosMsg
    {
        public SingleJointPositionActionGoal action_goal
        {
            get;
            set;
        }

        public SingleJointPositionActionResult action_result
        {
            get;
            set;
        }

        public SingleJointPositionActionFeedback action_feedback
        {
            get;
            set;
        }

        public SingleJointPositionAction(): base()
        {
        }

        public SingleJointPositionAction(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            action_goal = new SingleJointPositionActionGoal(binaryReader);
            action_result = new SingleJointPositionActionResult(binaryReader);
            action_feedback = new SingleJointPositionActionFeedback(binaryReader);
        }
    }
}