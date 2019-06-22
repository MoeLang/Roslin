namespace Roslin.Msg.posedetection_msgs
{
    [MsgInfo("posedetection_msgs/ObjectDetection", "450ee77eda8a92543774df0b858b3605", "Header header\nObject6DPose[] objects\n# unique image id these objects were taken from\n")]
    public partial class ObjectDetection : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Object6DPose[] objects
        {
            get;
            set;
        }

        public ObjectDetection(): base()
        {
        }

        public ObjectDetection(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            objects = new Object6DPose[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < objects . Length ;  i ++ ) objects [ i ]  =  new  Object6DPose ( binaryReader ) ; 
        }
    }
}