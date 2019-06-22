namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/RectArray", "e83b38fbaea3a641fa77f009f9bf492e", "Header header\nRect[] rects\n")]
    public partial class RectArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Rect[] rects
        {
            get;
            set;
        }

        public RectArray(): base()
        {
        }

        public RectArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(rects.Length); for  ( int  i  =  0 ;  i < rects . Length ;  i ++ ) rects [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            rects = new Rect[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < rects . Length ;  i ++ ) rects [ i ]  =  new  Rect ( binaryReader ) ; 
        }
    }
}