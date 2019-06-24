namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/ByteMultiArray", "70ea476cbcfd65ac2f68f3cda1e891fe", @"# Please look at the MultiArrayLayout message definition for
# documentation on all multiarrays.

MultiArrayLayout  layout        # specification of data layout
byte[]            data          # array of data

")]
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