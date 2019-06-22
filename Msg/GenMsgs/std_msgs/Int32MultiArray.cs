namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Int32MultiArray", "1d99f79f8b325b44fee908053e9c945b", "# Please look at the MultiArrayLayout message definition for\n# documentation on all multiarrays.\n\nMultiArrayLayout  layout        # specification of data layout\nint32[]           data          # array of data\n\n")]
    public partial class Int32MultiArray : RosMsg
    {
        public MultiArrayLayout layout
        {
            get;
            set;
        }

        public System.Int32[] data
        {
            get;
            set;
        }

        public Int32MultiArray(): base()
        {
        }

        public Int32MultiArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            layout.Serilize(binaryWriter);
            binaryWriter.Write(data.Length); for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) binaryWriter . Write ( data [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            layout = new MultiArrayLayout(binaryReader);
            data = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  binaryReader . ReadInt32 ( ) ; 
        }
    }
}