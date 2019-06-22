namespace Roslin.Msg.actionlib
{
    [MsgInfo("actionlib/TwoIntsActionFeedback", "aae20e09065c3809e8a8e87c4c8953fd", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nHeader header\nactionlib_msgs/GoalStatus status\nTwoIntsFeedback feedback\n")]
    public partial class TwoIntsActionFeedback : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public actionlib_msgs.GoalStatus status
        {
            get;
            set;
        }

        public TwoIntsFeedback feedback
        {
            get;
            set;
        }

        public TwoIntsActionFeedback(): base()
        {
        }

        public TwoIntsActionFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            status.Serilize(binaryWriter);
            feedback.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            status = new actionlib_msgs.GoalStatus(binaryReader);
            feedback = new TwoIntsFeedback(binaryReader);
        }
    }
}