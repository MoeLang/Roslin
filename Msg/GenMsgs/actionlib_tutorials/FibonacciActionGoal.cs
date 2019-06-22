namespace Roslin.Msg.actionlib_tutorials
{
    [MsgInfo("actionlib_tutorials/FibonacciActionGoal", "006871c7fa1d0e3d5fe2226bf17b2a94", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nHeader header\nactionlib_msgs/GoalID goal_id\nFibonacciGoal goal\n")]
    public partial class FibonacciActionGoal : RosMsg
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

        public FibonacciGoal goal
        {
            get;
            set;
        }

        public FibonacciActionGoal(): base()
        {
        }

        public FibonacciActionGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            goal = new FibonacciGoal(binaryReader);
        }
    }
}