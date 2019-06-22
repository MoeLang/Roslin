namespace Roslin.Msg.actionlib
{
    [MsgInfo("actionlib/TestActionGoal", "348369c5b403676156094e8c159720bf", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nHeader header\nactionlib_msgs/GoalID goal_id\nTestGoal goal\n")]
    public partial class TestActionGoal : RosMsg
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

        public TestGoal goal
        {
            get;
            set;
        }

        public TestActionGoal(): base()
        {
        }

        public TestActionGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            goal = new TestGoal(binaryReader);
        }
    }
}