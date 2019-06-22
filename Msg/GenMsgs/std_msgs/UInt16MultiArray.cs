namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/UInt16MultiArray", "52f264f1c973c4b73790d384c6cb4484", "# Please look at the MultiArrayLayout message definition for\n# documentation on all multiarrays.\n\nMultiArrayLayout  layout        # specification of data layout\nuint16[]            data        # array of data\n\n")]
    public partial class UInt16MultiArray : RosMsg
    {
        public MultiArrayLayout layout
        {
            get;
            set;
        }

        public System.UInt16[] data
        {
            get;
            set;
        }

        public UInt16MultiArray(): base()
        {
        }

        public UInt16MultiArray(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            data = new System.UInt16[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  binaryReader . ReadUInt16 ( ) ; 
        }
    }
}