namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/RegionOfInterest", "bdb633039d588fcccb441a4d43ccfe09", "# This message is used to specify a region of interest within an image.\n#\n# When used to specify the ROI setting of the camera when the image was\n# taken, the height and width fields should either match the height and\n# width fields for the associated image; or height = width = 0\n# indicates that the full resolution image was captured.\n\nuint32 x_offset  # Leftmost pixel of the ROI\n                 # (0 if the ROI includes the left edge of the image)\nuint32 y_offset  # Topmost pixel of the ROI\n                 # (0 if the ROI includes the top edge of the image)\nuint32 height    # Height of ROI\nuint32 width     # Width of ROI\n\n# True if a distinct rectified ROI should be calculated from the \"raw\"\n# ROI in this message. Typically this should be False if the full image\n# is captured (ROI not used), and True if a subwindow is captured (ROI\n# used).\nbool do_rectify\n")]
    public partial class RegionOfInterest : RosMsg
    {
        public System.UInt32 x_offset
        {
            get;
            set;
        }

        public System.UInt32 y_offset
        {
            get;
            set;
        }

        public System.UInt32 height
        {
            get;
            set;
        }

        public System.UInt32 width
        {
            get;
            set;
        }

        public System.Boolean do_rectify
        {
            get;
            set;
        }

        public RegionOfInterest(): base()
        {
        }

        public RegionOfInterest(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(x_offset);
            binaryWriter.Write(y_offset);
            binaryWriter.Write(height);
            binaryWriter.Write(width);
            binaryWriter.Write(do_rectify);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            x_offset = binaryReader.ReadUInt32();
            y_offset = binaryReader.ReadUInt32();
            height = binaryReader.ReadUInt32();
            width = binaryReader.ReadUInt32();
            do_rectify = binaryReader.ReadBoolean();
        }
    }
}