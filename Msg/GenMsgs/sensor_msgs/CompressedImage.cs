namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/CompressedImage", "8f7a12909da2c9d3332d540a0977563f", @"# This message contains a compressed image

Header header        # Header timestamp should be acquisition time of image
                     # Header frame_id should be optical frame of camera
                     # origin of frame should be optical center of camera
                     # +x should point to the right in the image
                     # +y should point down in the image
                     # +z should point into to plane of the image

string format        # Specifies the format of the data
                     #   Acceptable values:
                     #     jpeg, png
uint8[] data         # Compressed image buffer
")]
    public partial class CompressedImage : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String format
        {
            get;
            set;
        }

        public System.Byte[] data
        {
            get;
            set;
        }

        public CompressedImage(): base()
        {
        }

        public CompressedImage(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(format.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( format ) ) ; 
            binaryWriter.Write(data.Length); binaryWriter . Write ( data ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            format = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            data = new System.Byte[binaryReader.ReadInt32()]; data  =  binaryReader . ReadBytes ( data . Length ) ; 
        }
    }
}