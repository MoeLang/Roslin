namespace Roslin.Msg.turtle_actionlib
{
    [MsgInfo("turtle_actionlib/ShapeAction", "d73b17d6237a925511f5d7727a1dc903", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nShapeActionGoal action_goal\nShapeActionResult action_result\nShapeActionFeedback action_feedback\n")]
    public partial class ShapeAction : RosMsg
    {
        public ShapeActionGoal action_goal
        {
            get;
            set;
        }

        public ShapeActionResult action_result
        {
            get;
            set;
        }

        public ShapeActionFeedback action_feedback
        {
            get;
            set;
        }

        public ShapeAction(): base()
        {
        }

        public ShapeAction(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            action_goal = new ShapeActionGoal(binaryReader);
            action_result = new ShapeActionResult(binaryReader);
            action_feedback = new ShapeActionFeedback(binaryReader);
        }
    }
}