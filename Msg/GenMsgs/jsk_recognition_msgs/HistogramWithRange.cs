namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/HistogramWithRange", "aa922a22cbdcbdcc1146f30df5b605b8", @"Header header
HistogramWithRangeBin[] bins

")]
    public partial class HistogramWithRange : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public HistogramWithRangeBin[] bins
        {
            get;
            set;
        }

        public HistogramWithRange(): base()
        {
        }

        public HistogramWithRange(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(bins.Length); for  ( int  i  =  0 ;  i < bins . Length ;  i ++ ) bins [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            bins = new HistogramWithRangeBin[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < bins . Length ;  i ++ ) bins [ i ]  =  new  HistogramWithRangeBin ( binaryReader ) ; 
        }
    }
}