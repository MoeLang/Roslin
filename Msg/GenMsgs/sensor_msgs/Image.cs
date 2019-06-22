namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/Image", "060021388200f6f0f447d0fcd9c64743", "# This message contains an uncompressed image\n# (0, 0) is at top-left corner of image\n#\n\nHeader header        # Header timestamp should be acquisition time of image\n                     # Header frame_id should be optical frame of camera\n                     # origin of frame should be optical center of camera\n                     # +x should point to the right in the image\n                     # +y should point down in the image\n                     # +z should point into to plane of the image\n                     # If the frame_id here and the frame_id of the CameraInfo\n                     # message associated with the image conflict\n                     # the behavior is undefined\n\nuint32 height         # image height, that is, number of rows\nuint32 width          # image width, that is, number of columns\n\n# The legal values for encoding are in file src/image_encodings.cpp\n# If you want to standardize a new string format, join\n# ros-users@lists.sourceforge.net and send an email proposing a new encoding.\n\nstring encoding       # Encoding of pixels -- channel meaning, ordering, size\n                      # taken from the list of strings in include/sensor_msgs/image_encodings.h\n\nuint8 is_bigendian    # is this data bigendian?\nuint32 step           # Full row length in bytes\nuint8[] data          # actual matrix data, size is (step * rows)\n")]
    public partial class Image : RosMsg
    {
        public std_msgs.Header header
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

        public System.String encoding
        {
            get;
            set;
        }

        public System.Byte is_bigendian
        {
            get;
            set;
        }

        public System.UInt32 step
        {
            get;
            set;
        }

        public System.Byte[] data
        {
            get;
            set;
        }

        public Image(): base()
        {
        }

        public Image(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(height);
            binaryWriter.Write(width);
            binaryWriter.Write(encoding.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( encoding ) ) ; 
            binaryWriter.Write(is_bigendian);
            binaryWriter.Write(step);
            binaryWriter.Write(data.Length); binaryWriter . Write ( data ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            height = binaryReader.ReadUInt32();
            width = binaryReader.ReadUInt32();
            encoding = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            is_bigendian = binaryReader.ReadByte();
            step = binaryReader.ReadUInt32();
            data = new System.Byte[binaryReader.ReadInt32()]; data  =  binaryReader . ReadBytes ( data . Length ) ; 
        }
    }
}