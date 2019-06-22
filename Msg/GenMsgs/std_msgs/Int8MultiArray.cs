namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Int8MultiArray", "d7c1af35a1b4781bbe79e03dd94b7c13", "# Please look at the MultiArrayLayout message definition for\n# documentation on all multiarrays.\n\nMultiArrayLayout  layout        # specification of data layout\nint8[]            data          # array of data\n\n")]
    public partial class Int8MultiArray : RosMsg
    {
        public MultiArrayLayout layout
        {
            get;
            set;
        }

        public System.SByte[] data
        {
            get;
            set;
        }

        public Int8MultiArray(): base()
        {
        }

        public Int8MultiArray(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            data = new System.SByte[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  binaryReader . ReadSByte ( ) ; 
        }
    }
}