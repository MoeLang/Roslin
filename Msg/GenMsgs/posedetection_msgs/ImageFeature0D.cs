namespace Roslin.Msg.posedetection_msgs
{
    [MsgInfo("posedetection_msgs/ImageFeature0D", "a16c5327c89b15820420449cf843ed75", @"# synchronized image and features message
sensor_msgs/Image image
sensor_msgs/CameraInfo info
posedetection_msgs/Feature0D features
")]
    public partial class ImageFeature0D : RosMsg
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

        public posedetection_msgs.Feature0D features
        {
            get;
            set;
        }

        public ImageFeature0D(): base()
        {
        }

        public ImageFeature0D(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            features = new posedetection_msgs.Feature0D(binaryReader);
        }
    }
}