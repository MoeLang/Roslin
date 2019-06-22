namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/ByteMultiArray", "70ea476cbcfd65ac2f68f3cda1e891fe", "# Please look at the MultiArrayLayout message definition for\n# documentation on all multiarrays.\n\nMultiArrayLayout  layout        # specification of data layout\nbyte[]            data          # array of data\n\n")]
    public partial class ByteMultiArray : RosMsg
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

        public ByteMultiArray(): base()
        {
        }

        public ByteMultiArray(System.IO.BinaryReader binaryReader): base(binaryReader)
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