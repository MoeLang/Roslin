namespace Roslin.Msg.actionlib_tutorials
{
    [MsgInfo("actionlib_tutorials/AveragingGoal", "32c9b10ef9b253faa93b93f564762c8f", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
#goal definition
int32 samples
")]
    public partial class AveragingGoal : RosMsg
    {
        public System.Int32 samples
        {
            get;
            set;
        }

        public AveragingGoal(): base()
        {
        }

        public AveragingGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(samples);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            samples = binaryReader.ReadInt32();
        }
    }
}