namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/LineArray", "1571346a320fd11e0b7dc11a90a72ddf", @"Header header
Line[] lines

")]
    public partial class LineArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Line[] lines
        {
            get;
            set;
        }

        public LineArray(): base()
        {
        }

        public LineArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(lines.Length); for  ( int  i  =  0 ;  i < lines . Length ;  i ++ ) lines [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            lines = new Line[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < lines . Length ;  i ++ ) lines [ i ]  =  new  Line ( binaryReader ) ; 
        }
    }
}