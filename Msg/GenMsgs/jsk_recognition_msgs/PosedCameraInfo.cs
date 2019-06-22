namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/PosedCameraInfo", "bfcbc4847adb445a428e4af537ed849a", "Header header\nsensor_msgs/CameraInfo camera_info\ngeometry_msgs/Pose offset\n")]
    public partial class PosedCameraInfo : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public sensor_msgs.CameraInfo camera_info
        {
            get;
            set;
        }

        public geometry_msgs.Pose offset
        {
            get;
            set;
        }

        public PosedCameraInfo(): base()
        {
        }

        public PosedCameraInfo(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            camera_info.Serilize(binaryWriter);
            offset.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            camera_info = new sensor_msgs.CameraInfo(binaryReader);
            offset = new geometry_msgs.Pose(binaryReader);
        }
    }
}