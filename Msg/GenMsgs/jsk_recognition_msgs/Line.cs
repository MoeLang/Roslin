namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Line", "3010fad09b09b8d3fdecdd94d144f7a1", "float64 x1\nfloat64 y1\nfloat64 x2\nfloat64 y2\n\n\n")]
    public partial class Line : RosMsg
    {
        public System.Double x1
        {
            get;
            set;
        }

        public System.Double y1
        {
            get;
            set;
        }

        public System.Double x2
        {
            get;
            set;
        }

        public System.Double y2
        {
            get;
            set;
        }

        public Line(): base()
        {
        }

        public Line(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(x1);
            binaryWriter.Write(y1);
            binaryWriter.Write(x2);
            binaryWriter.Write(y2);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            x1 = binaryReader.ReadDouble();
            y1 = binaryReader.ReadDouble();
            x2 = binaryReader.ReadDouble();
            y2 = binaryReader.ReadDouble();
        }
    }
}