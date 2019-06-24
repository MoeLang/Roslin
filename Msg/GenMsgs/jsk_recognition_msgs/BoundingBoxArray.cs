namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/BoundingBoxArray", "c8f4a8bb1acd18ce778d183912bb472d", @"# BoundingBoxArray is a list of BoundingBox.
# You can use jsk_rviz_plugins to visualize BoungingBoxArray on rviz.
Header header
BoundingBox[] boxes
")]
    public partial class BoundingBoxArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public BoundingBox[] boxes
        {
            get;
            set;
        }

        public BoundingBoxArray(): base()
        {
        }

        public BoundingBoxArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(boxes.Length); for  ( int  i  =  0 ;  i < boxes . Length ;  i ++ ) boxes [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            boxes = new BoundingBox[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < boxes . Length ;  i ++ ) boxes [ i ]  =  new  BoundingBox ( binaryReader ) ; 
        }
    }
}