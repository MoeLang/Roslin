namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/PointHeadActionGoal", "b53a8323d0ba7b310ba17a2d3a82a6b8", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

Header header
actionlib_msgs/GoalID goal_id
PointHeadGoal goal
")]
    public partial class PointHeadActionGoal : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public actionlib_msgs.GoalID goal_id
        {
            get;
            set;
        }

        public PointHeadGoal goal
        {
            get;
            set;
        }

        public PointHeadActionGoal(): base()
        {
        }

        public PointHeadActionGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            goal_id.Serilize(binaryWriter);
            goal.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            goal_id = new actionlib_msgs.GoalID(binaryReader);
            goal = new PointHeadGoal(binaryReader);
        }
    }
}