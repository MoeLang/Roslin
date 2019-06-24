namespace Roslin.Msg.jsk_footstep_msgs
{
    [MsgInfo("jsk_footstep_msgs/ExecFootstepsGoal", "bb8b96be7f0085372e05a467f65017bb", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
# goal
uint8 NEW_TARGET=0
uint8 RESUME=1
FootstepArray footstep
uint8 strategy
")]
    public partial class ExecFootstepsGoal : RosMsg
    {
        public System.Byte NEW_TARGET => 0;
        public System.Byte RESUME => 1;
        public FootstepArray footstep
        {
            get;
            set;
        }

        public System.Byte strategy
        {
            get;
            set;
        }

        public ExecFootstepsGoal(): base()
        {
        }

        public ExecFootstepsGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            footstep.Serilize(binaryWriter);
            binaryWriter.Write(strategy);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            footstep = new FootstepArray(binaryReader);
            strategy = binaryReader.ReadByte();
        }
    }
}