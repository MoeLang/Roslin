namespace Roslin.Msg.stereo_msgs
{
    [MsgInfo("stereo_msgs/DisparityImage", "04a177815f75271039fa21f16acad8c9", @"# Separate header for compatibility with current TimeSynchronizer.
# Likely to be removed in a later release, use image.header instead.
Header header

# Floating point disparity image. The disparities are pre-adjusted for any
# x-offset between the principal points of the two cameras (in the case
# that they are verged). That is: d = x_l - x_r - (cx_l - cx_r)
sensor_msgs/Image image

# Stereo geometry. For disparity d, the depth from the camera is Z = fT/d.
float32 f # Focal length, pixels
float32 T # Baseline, world units

# Subwindow of (potentially) valid disparity values.
sensor_msgs/RegionOfInterest valid_window

# The range of disparities searched.
# In the disparity image, any disparity less than min_disparity is invalid.
# The disparity search range defines the horopter, or 3D volume that the
# stereo algorithm can ""see"". Points with Z outside of:
#     Z_min = fT / max_disparity
#     Z_max = fT / min_disparity
# could not be found.
float32 min_disparity
float32 max_disparity

# Smallest allowed disparity increment. The smallest achievable depth range
# resolution is delta_Z = (Z^2/fT)*delta_d.
float32 delta_d
")]
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