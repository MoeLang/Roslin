namespace Roslin.Msg.pcl_msgs
{
    [MsgInfo("pcl_msgs/PointIndices", "458c7998b7eaf99908256472e273b3d4", "Header header\nint32[] indices\n\n")]
    public partial class PointIndices : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Int32[] indices
        {
            get;
            set;
        }

        public PointIndices(): base()
        {
        }

        public PointIndices(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(indices.Length); for  ( int  i  =  0 ;  i < indices . Length ;  i ++ ) binaryWriter . Write ( indices [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            indices = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < indices . Length ;  i ++ ) indices [ i ]  =  binaryReader . ReadInt32 ( ) ; 
        }
    }
}