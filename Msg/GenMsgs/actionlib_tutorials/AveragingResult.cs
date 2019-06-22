namespace Roslin.Msg.actionlib_tutorials
{
    [MsgInfo("actionlib_tutorials/AveragingResult", "d5c7decf6df75ffb4367a05c1bcc7612", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n#result definition\nfloat32 mean\nfloat32 std_dev\n")]
    public partial class AveragingResult : RosMsg
    {
        public System.Single mean
        {
            get;
            set;
        }

        public System.Single std_dev
        {
            get;
            set;
        }

        public AveragingResult(): base()
        {
        }

        public AveragingResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(mean);
            binaryWriter.Write(std_dev);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            mean = binaryReader.ReadSingle();
            std_dev = binaryReader.ReadSingle();
        }
    }
}