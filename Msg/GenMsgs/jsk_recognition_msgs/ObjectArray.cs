namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ObjectArray", "36314156578f919cf316fea64cc4a616", "Header header\njsk_recognition_msgs/Object[] objects\n")]
    public partial class ObjectArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public jsk_recognition_msgs.Object[] objects
        {
            get;
            set;
        }

        public ObjectArray(): base()
        {
        }

        public ObjectArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(objects.Length); for  ( int  i  =  0 ;  i < objects . Length ;  i ++ ) objects [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            objects = new jsk_recognition_msgs.Object[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < objects . Length ;  i ++ ) objects [ i ]  =  new  jsk_recognition_msgs . Object ( binaryReader ) ; 
        }
    }
}