namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/RotatedRect", "e970c93bbd35a570f7d9acc8228e9280", @"float64 x
float64 y
float64 width
float64 height
float64 angle # degree
")]
    public partial class RotatedRect : RosMsg
    {
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

        public System.Double width
        {
            get;
            set;
        }

        public System.Double height
        {
            get;
            set;
        }

        public System.Double angle
        {
            get;
            set;
        }

        public RotatedRect(): base()
        {
        }

        public RotatedRect(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(width);
            binaryWriter.Write(height);
            binaryWriter.Write(angle);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            x = binaryReader.ReadDouble();
            y = binaryReader.ReadDouble();
            width = binaryReader.ReadDouble();
            height = binaryReader.ReadDouble();
            angle = binaryReader.ReadDouble();
        }
    }
}