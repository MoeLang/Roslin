namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/MultiArrayDimension", "4cd0c83a8683deae40ecdac60e53bfa8", "string label   # label of given dimension\nuint32 size    # size of given dimension (in type units)\nuint32 stride  # stride of given dimension")]
    public partial class MultiArrayDimension : RosMsg
    {
        public System.String label
        {
            get;
            set;
        }

        public System.UInt32 size
        {
            get;
            set;
        }

        public System.UInt32 stride
        {
            get;
            set;
        }

        public MultiArrayDimension(): base()
        {
        }

        public MultiArrayDimension(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(label.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( label ) ) ; 
            binaryWriter.Write(size);
            binaryWriter.Write(stride);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            label = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            size = binaryReader.ReadUInt32();
            stride = binaryReader.ReadUInt32();
        }
    }
}