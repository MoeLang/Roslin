namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/VectorArray", "5755776409eb8318e94c95cd52de2b69", "Header header\nint32 vector_dim\nfloat64[] data\n")]
    public partial class VectorArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Int32 vector_dim
        {
            get;
            set;
        }

        public System.Double[] data
        {
            get;
            set;
        }

        public VectorArray(): base()
        {
        }

        public VectorArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(vector_dim);
            binaryWriter.Write(data.Length); for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) binaryWriter . Write ( data [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            vector_dim = binaryReader.ReadInt32();
            data = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}