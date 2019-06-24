namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SparseImage", "7c361d829424bc5984fc0a1831f84751", @"Header header

uint32 width
uint32 height

# each uint8 or uint16 contains position of white pixel expressed like: ""(x << 8 or 16) ^ y""
# if max(width, height) > 256(=2^8) use data32 array, else use data16 array.
uint16[] data16
uint32[] data32
")]
    public partial class SparseImage : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt32 width
        {
            get;
            set;
        }

        public System.UInt32 height
        {
            get;
            set;
        }

        public System.UInt16[] data16
        {
            get;
            set;
        }

        public System.UInt32[] data32
        {
            get;
            set;
        }

        public SparseImage(): base()
        {
        }

        public SparseImage(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(width);
            binaryWriter.Write(height);
            binaryWriter.Write(data16.Length); for  ( int  i  =  0 ;  i < data16 . Length ;  i ++ ) binaryWriter . Write ( data16 [ i ] ) ; 
            binaryWriter.Write(data32.Length); for  ( int  i  =  0 ;  i < data32 . Length ;  i ++ ) binaryWriter . Write ( data32 [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            width = binaryReader.ReadUInt32();
            height = binaryReader.ReadUInt32();
            data16 = new System.UInt16[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data16 . Length ;  i ++ ) data16 [ i ]  =  binaryReader . ReadUInt16 ( ) ; 
            data32 = new System.UInt32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data32 . Length ;  i ++ ) data32 [ i ]  =  binaryReader . ReadUInt32 ( ) ; 
        }
    }
}