namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ColorHistogram", "5b08641478fdecd8720ba08b36fce2aa", "Header header\nfloat32[] histogram\n")]
    public partial class ColorHistogram : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single[] histogram
        {
            get;
            set;
        }

        public ColorHistogram(): base()
        {
        }

        public ColorHistogram(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            histogram = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < histogram . Length ;  i ++ ) histogram [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}