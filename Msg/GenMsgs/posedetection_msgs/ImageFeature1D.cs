namespace Roslin.Msg.posedetection_msgs
{
    [MsgInfo("posedetection_msgs/ImageFeature1D", "bfd3a262e6342c55b7e11fccf00d8b2c", "# synchronized image and features message\nsensor_msgs/Image image\nsensor_msgs/CameraInfo info\nposedetection_msgs/Feature1D features\n")]
    public partial class ImageFeature1D : RosMsg
    {
        public sensor_msgs.Image image
        {
            get;
            set;
        }

        public sensor_msgs.CameraInfo info
        {
            get;
            set;
        }

        public posedetection_msgs.Feature1D features
        {
            get;
            set;
        }

        public ImageFeature1D(): base()
        {
        }

        public ImageFeature1D(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            image.Serilize(binaryWriter);
            info.Serilize(binaryWriter);
            features.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            image = new sensor_msgs.Image(binaryReader);
            info = new sensor_msgs.CameraInfo(binaryReader);
            features = new posedetection_msgs.Feature1D(binaryReader);
        }
    }
}