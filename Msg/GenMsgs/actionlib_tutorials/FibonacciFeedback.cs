namespace Roslin.Msg.actionlib_tutorials
{
    [MsgInfo("actionlib_tutorials/FibonacciFeedback", "b81e37d2a31925a0e8ae261a8699cb79", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
#feedback
int32[] sequence

")]
    public partial class FibonacciFeedback : RosMsg
    {
        public System.Int32[] sequence
        {
            get;
            set;
        }

        public FibonacciFeedback(): base()
        {
        }

        public FibonacciFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(sequence.Length); for  ( int  i  =  0 ;  i < sequence . Length ;  i ++ ) binaryWriter . Write ( sequence [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            sequence = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < sequence . Length ;  i ++ ) sequence [ i ]  =  binaryReader . ReadInt32 ( ) ; 
        }
    }
}