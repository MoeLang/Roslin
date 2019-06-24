namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Histogram", "376372f016c22c39ab7ee6b6bdd0f10a", @"Header header
float64[] histogram
")]
    public partial class Histogram : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double[] histogram
        {
            get;
            set;
        }

        public Histogram(): base()
        {
        }

        public Histogram(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(histogram.Length); for  ( int  i  =  0 ;  i < histogram . Length ;  i ++ ) binaryWriter . Write ( histogram [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            histogram = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < histogram . Length ;  i ++ ) histogram [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}