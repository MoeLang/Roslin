namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ColorHistogramArray", "3bcc7f05c5520f311047096d5530e715", @"Header header
ColorHistogram[] histograms
")]
    public partial class ColorHistogramArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public ColorHistogram[] histograms
        {
            get;
            set;
        }

        public ColorHistogramArray(): base()
        {
        }

        public ColorHistogramArray(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            histograms = new ColorHistogram[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < histograms . Length ;  i ++ ) histograms [ i ]  =  new  ColorHistogram ( binaryReader ) ; 
        }
    }
}