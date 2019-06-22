namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/UInt64MultiArray", "6088f127afb1d6c72927aa1247e945af", "# Please look at the MultiArrayLayout message definition for\n# documentation on all multiarrays.\n\nMultiArrayLayout  layout        # specification of data layout\nuint64[]          data          # array of data\n\n")]
    public partial class UInt64MultiArray : RosMsg
    {
        public MultiArrayLayout layout
        {
            get;
            set;
        }

        public System.UInt64[] data
        {
            get;
            set;
        }

        public UInt64MultiArray(): base()
        {
        }

        public UInt64MultiArray(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            data = new System.UInt64[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  binaryReader . ReadUInt64 ( ) ; 
        }
    }
}