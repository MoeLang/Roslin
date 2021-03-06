namespace Roslin.Msg.sound_play
{
    [MsgInfo("sound_play/SoundRequestActionGoal", "7ff89ce2a5f72c86a28be8ae82658bf8", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

Header header
actionlib_msgs/GoalID goal_id
SoundRequestGoal goal
")]
    public partial class SoundRequestActionGoal : RosMsg
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

        public SoundRequestGoal goal
        {
            get;
            set;
        }

        public SoundRequestActionGoal(): base()
        {
        }

        public SoundRequestActionGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            goal = new SoundRequestGoal(binaryReader);
        }
    }
}