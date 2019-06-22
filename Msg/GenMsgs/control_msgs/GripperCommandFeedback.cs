namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/GripperCommandFeedback", "e4cbff56d3562bcf113da5a5adeef91f", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\nfloat64 position  # The current gripper gap size (in meters)\nfloat64 effort    # The current effort exerted (in Newtons)\nbool stalled      # True iff the gripper is exerting max effort and not moving\nbool reached_goal # True iff the gripper position has reached the commanded setpoint\n\n")]
    public partial class GripperCommandFeedback : RosMsg
    {
        public System.Double position
        {
            get;
            set;
        }

        public System.Double effort
        {
            get;
            set;
        }

        public System.Boolean stalled
        {
            get;
            set;
        }

        public System.Boolean reached_goal
        {
            get;
            set;
        }

        public GripperCommandFeedback(): base()
        {
        }

        public GripperCommandFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(position);
            binaryWriter.Write(effort);
            binaryWriter.Write(stalled);
            binaryWriter.Write(reached_goal);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            position = binaryReader.ReadDouble();
            effort = binaryReader.ReadDouble();
            stalled = binaryReader.ReadBoolean();
            reached_goal = binaryReader.ReadBoolean();
        }
    }
}