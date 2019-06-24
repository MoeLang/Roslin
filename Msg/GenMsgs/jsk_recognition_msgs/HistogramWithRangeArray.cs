namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/HistogramWithRangeArray", "2622b1b7ae84f154677cf4c0d3a398c7", @"Header header
HistogramWithRange[] histograms


")]
    public partial class HistogramWithRangeArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public HistogramWithRange[] histograms
        {
            get;
            set;
        }

        public HistogramWithRangeArray(): base()
        {
        }

        public HistogramWithRangeArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(histograms.Length); for  ( int  i  =  0 ;  i < histograms . Length ;  i ++ ) histograms [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            histograms = new HistogramWithRange[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < histograms . Length ;  i ++ ) histograms [ i ]  =  new  HistogramWithRange ( binaryReader ) ; 
        }
    }
}