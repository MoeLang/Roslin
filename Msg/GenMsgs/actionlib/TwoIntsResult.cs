namespace Roslin.Msg.actionlib
{
    [MsgInfo("actionlib/TwoIntsResult", "b88405221c77b1878a3cbbfff53428d7", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
int64 sum
")]
    public partial class TwoIntsResult : RosMsg
    {
        public System.Int64 sum
        {
            get;
            set;
        }

        public TwoIntsResult(): base()
        {
        }

        public TwoIntsResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(sum);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            sum = binaryReader.ReadInt64();
        }
    }
}