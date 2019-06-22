namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/Touch", "d96a284d39fcc410f375ac68fd380177", "# finger_id\nint64 finger_id\n# touch point(screen point)\nfloat64 x\nfloat64 y\n# based image size (usually not needed)\nint64 image_width\nint64 image_height")]
    public partial class Touch : RosMsg
    {
        public System.Int64 finger_id
        {
            get;
            set;
        }

        public System.Double x
        {
            get;
            set;
        }

        public System.Double y
        {
            get;
            set;
        }

        public System.Int64 image_width
        {
            get;
            set;
        }

        public System.Int64 image_height
        {
            get;
            set;
        }

        public Touch(): base()
        {
        }

        public Touch(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(finger_id);
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(image_width);
            binaryWriter.Write(image_height);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            finger_id = binaryReader.ReadInt64();
            x = binaryReader.ReadDouble();
            y = binaryReader.ReadDouble();
            image_width = binaryReader.ReadInt64();
            image_height = binaryReader.ReadInt64();
        }
    }
}