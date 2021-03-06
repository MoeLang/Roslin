namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/GripperCommandActionGoal", "aa581f648a35ed681db2ec0bf7a82bea", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

Header header
actionlib_msgs/GoalID goal_id
GripperCommandGoal goal
")]
    public partial class GripperCommandActionGoal : RosMsg
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

        public GripperCommandGoal goal
        {
            get;
            set;
        }

        public GripperCommandActionGoal(): base()
        {
        }

        public GripperCommandActionGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            goal = new GripperCommandGoal(binaryReader);
        }
    }
}