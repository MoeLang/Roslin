namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SegmentArray", "672a84c8545e1a65663c5497ab1a917c", "Header header\nSegment[] segments\n")]
    public partial class SegmentArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Segment[] segments
        {
            get;
            set;
        }

        public SegmentArray(): base()
        {
        }

        public SegmentArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(segments.Length); for  ( int  i  =  0 ;  i < segments . Length ;  i ++ ) segments [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            segments = new Segment[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < segments . Length ;  i ++ ) segments [ i ]  =  new  Segment ( binaryReader ) ; 
        }
    }
}