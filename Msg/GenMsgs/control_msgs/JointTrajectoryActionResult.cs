namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/JointTrajectoryActionResult", "1eb06eeff08fa7ea874431638cb52332", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nHeader header\nactionlib_msgs/GoalStatus status\nJointTrajectoryResult result\n")]
    public partial class JointTrajectoryActionResult : RosMsg
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

        public JointTrajectoryResult result
        {
            get;
            set;
        }

        public JointTrajectoryActionResult(): base()
        {
        }

        public JointTrajectoryActionResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            status.Serilize(binaryWriter);
            result.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            status = new actionlib_msgs.GoalStatus(binaryReader);
            result = new JointTrajectoryResult(binaryReader);
        }
    }
}