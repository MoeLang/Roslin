namespace Roslin.Msg.actionlib_tutorials
{
    [MsgInfo("actionlib_tutorials/FibonacciGoal", "6889063349a00b249bd1661df429d822", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n#goal definition\nint32 order\n")]
    public partial class FibonacciGoal : RosMsg
    {
        public System.Int32 order
        {
            get;
            set;
        }

        public FibonacciGoal(): base()
        {
        }

        public FibonacciGoal(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(order);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            order = binaryReader.ReadInt32();
        }
    }
}