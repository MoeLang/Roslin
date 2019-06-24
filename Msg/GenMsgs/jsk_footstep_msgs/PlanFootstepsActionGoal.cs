namespace Roslin.Msg.jsk_footstep_msgs
{
    [MsgInfo("jsk_footstep_msgs/PlanFootstepsActionGoal", "4f600ecca20b1d57f2e38560d26042c4", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

Header header
actionlib_msgs/GoalID goal_id
PlanFootstepsGoal goal
")]
    public partial class PlanFootstepsActionGoal : RosMsg
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

        public PlanFootstepsGoal goal
        {
            get;
            set;
        }

        public PlanFootstepsActionGoal(): base()
        {
        }

        public PlanFootstepsActionGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            goal = new PlanFootstepsGoal(binaryReader);
        }
    }
}