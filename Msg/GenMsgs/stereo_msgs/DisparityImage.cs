namespace Roslin.Msg.stereo_msgs
{
    [MsgInfo("stereo_msgs/DisparityImage", "04a177815f75271039fa21f16acad8c9", "# Separate header for compatibility with current TimeSynchronizer.\n# Likely to be removed in a later release, use image.header instead.\nHeader header\n\n# Floating point disparity image. The disparities are pre-adjusted for any\n# x-offset between the principal points of the two cameras (in the case\n# that they are verged). That is: d = x_l - x_r - (cx_l - cx_r)\nsensor_msgs/Image image\n\n# Stereo geometry. For disparity d, the depth from the camera is Z = fT/d.\nfloat32 f # Focal length, pixels\nfloat32 T # Baseline, world units\n\n# Subwindow of (potentially) valid disparity values.\nsensor_msgs/RegionOfInterest valid_window\n\n# The range of disparities searched.\n# In the disparity image, any disparity less than min_disparity is invalid.\n# The disparity search range defines the horopter, or 3D volume that the\n# stereo algorithm can \"see\". Points with Z outside of:\n#     Z_min = fT / max_disparity\n#     Z_max = fT / min_disparity\n# could not be found.\nfloat32 min_disparity\nfloat32 max_disparity\n\n# Smallest allowed disparity increment. The smallest achievable depth range\n# resolution is delta_Z = (Z^2/fT)*delta_d.\nfloat32 delta_d\n")]
    public partial class DisparityImage : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public sensor_msgs.Image image
        {
            get;
            set;
        }

        public System.Single f
        {
            get;
            set;
        }

        public System.Single T
        {
            get;
            set;
        }

        public sensor_msgs.RegionOfInterest valid_window
        {
            get;
            set;
        }

        public System.Single min_disparity
        {
            get;
            set;
        }

        public System.Single max_disparity
        {
            get;
            set;
        }

        public System.Single delta_d
        {
            get;
            set;
        }

        public DisparityImage(): base()
        {
        }

        public DisparityImage(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            image.Serilize(binaryWriter);
            binaryWriter.Write(f);
            binaryWriter.Write(T);
            valid_window.Serilize(binaryWriter);
            binaryWriter.Write(min_disparity);
            binaryWriter.Write(max_disparity);
            binaryWriter.Write(delta_d);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            image = new sensor_msgs.Image(binaryReader);
            f = binaryReader.ReadSingle();
            T = binaryReader.ReadSingle();
            valid_window = new sensor_msgs.RegionOfInterest(binaryReader);
            min_disparity = binaryReader.ReadSingle();
            max_disparity = binaryReader.ReadSingle();
            delta_d = binaryReader.ReadSingle();
        }
    }
}