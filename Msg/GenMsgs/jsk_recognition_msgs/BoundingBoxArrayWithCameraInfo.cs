namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/BoundingBoxArrayWithCameraInfo", "e68d75609bb0b7f4ac5831524b0126e7", @"Header header
BoundingBoxArray boxes
sensor_msgs/CameraInfo camera_info
")]
    public partial class BoundingBoxArrayWithCameraInfo : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public BoundingBoxArray boxes
        {
            get;
            set;
        }

        public sensor_msgs.CameraInfo camera_info
        {
            get;
            set;
        }

        public BoundingBoxArrayWithCameraInfo(): base()
        {
        }

        public BoundingBoxArrayWithCameraInfo(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            boxes.Serilize(binaryWriter);
            camera_info.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            boxes = new BoundingBoxArray(binaryReader);
            camera_info = new sensor_msgs.CameraInfo(binaryReader);
        }
    }
}