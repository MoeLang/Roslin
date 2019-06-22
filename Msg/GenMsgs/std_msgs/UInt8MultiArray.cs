namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/UInt8MultiArray", "82373f1612381bb6ee473b5cd6f5d89c", "# Please look at the MultiArrayLayout message definition for\n# documentation on all multiarrays.\n\nMultiArrayLayout  layout        # specification of data layout\nuint8[]           data          # array of data\n\n")]
    public partial class UInt8MultiArray : RosMsg
    {
        public MultiArrayLayout layout
        {
            get;
            set;
        }

        public System.Byte[] data
        {
            get;
            set;
        }

        public UInt8MultiArray(): base()
        {
        }

        public UInt8MultiArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            layout.Serilize(binaryWriter);
            binaryWriter.Write(data.Length); binaryWriter . Write ( data ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            layout = new MultiArrayLayout(binaryReader);
            data = new System.Byte[binaryReader.ReadInt32()]; data  =  binaryReader . ReadBytes ( data . Length ) ; 
        }
    }
}