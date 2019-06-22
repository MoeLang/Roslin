namespace Roslin.Msg.tf2_msgs
{
    [MsgInfo("tf2_msgs/LookupTransformActionFeedback", "aae20e09065c3809e8a8e87c4c8953fd", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nHeader header\nactionlib_msgs/GoalStatus status\nLookupTransformFeedback feedback\n")]
    public partial class LookupTransformActionFeedback : RosMsg
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

        public LookupTransformFeedback feedback
        {
            get;
            set;
        }

        public LookupTransformActionFeedback(): base()
        {
        }

        public LookupTransformActionFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            feedback = new LookupTransformFeedback(binaryReader);
        }
    }
}