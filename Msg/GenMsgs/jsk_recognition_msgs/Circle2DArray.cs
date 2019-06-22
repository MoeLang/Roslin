namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Circle2DArray", "7c3f0f08758538a1e02ce600cf99132f", "Header header\nCircle2D[] circles\n")]
    public partial class Circle2DArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Circle2D[] circles
        {
            get;
            set;
        }

        public Circle2DArray(): base()
        {
        }

        public Circle2DArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(circles.Length); for  ( int  i  =  0 ;  i < circles . Length ;  i ++ ) circles [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            circles = new Circle2D[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < circles . Length ;  i ++ ) circles [ i ]  =  new  Circle2D ( binaryReader ) ; 
        }
    }
}