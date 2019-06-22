namespace Roslin.Msg.actionlib_msgs
{
    [MsgInfo("actionlib_msgs/GoalID", "302881f31927c1df708a2dbab0e80ee8", "# The stamp should store the time at which this goal was requested.\n# It is used by an action server when it tries to preempt all\n# goals that were requested before a certain time\ntime stamp\n\n# The id provides a way to associate feedback and\n# result message with specific goal requests. The id\n# specified must be unique.\nstring id\n\n")]
    public partial class GoalID : RosMsg
    {
        public System.DateTime stamp
        {
            get;
            set;
        }

        public System.String id
        {
            get;
            set;
        }

        public GoalID(): base()
        {
        }

        public GoalID(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(stamp);
            binaryWriter.Write(id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( id ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            stamp = binaryReader.ReadDateTime();
            id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}