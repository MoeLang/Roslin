namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/GripperCommandAction", "950b2a6ebe831f5d4f4ceaba3d8be01e", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nGripperCommandActionGoal action_goal\nGripperCommandActionResult action_result\nGripperCommandActionFeedback action_feedback\n")]
    public partial class GripperCommandAction : RosMsg
    {
        public GripperCommandActionGoal action_goal
        {
            get;
            set;
        }

        public GripperCommandActionResult action_result
        {
            get;
            set;
        }

        public GripperCommandActionFeedback action_feedback
        {
            get;
            set;
        }

        public GripperCommandAction(): base()
        {
        }

        public GripperCommandAction(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            action_goal = new GripperCommandActionGoal(binaryReader);
            action_result = new GripperCommandActionResult(binaryReader);
            action_feedback = new GripperCommandActionFeedback(binaryReader);
        }
    }
}