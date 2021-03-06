namespace Roslin.Msg.jsk_footstep_msgs
{
    [MsgInfo("jsk_footstep_msgs/PlanFootstepsGoal", "68011023a311776030c53b8ca437fae1", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
# goal
FootstepArray goal_footstep
FootstepArray initial_footstep
duration timeout
")]
    public partial class PlanFootstepsGoal : RosMsg
    {
        public FootstepArray goal_footstep
        {
            get;
            set;
        }

        public FootstepArray initial_footstep
        {
            get;
            set;
        }

        public System.TimeSpan timeout
        {
            get;
            set;
        }

        public PlanFootstepsGoal(): base()
        {
        }

        public PlanFootstepsGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            goal_footstep.Serilize(binaryWriter);
            initial_footstep.Serilize(binaryWriter);
            binaryWriter.Write(timeout);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            goal_footstep = new FootstepArray(binaryReader);
            initial_footstep = new FootstepArray(binaryReader);
            timeout = binaryReader.ReadTimeSpan();
        }
    }
}