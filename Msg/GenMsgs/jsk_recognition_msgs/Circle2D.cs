namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Circle2D", "2337fe90a715387bfdc3cf4b7fa2391e", "Header header\nfloat64 radius\nfloat64 x\nfloat64 y\n")]
    public partial class Circle2D : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double radius
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

        public Circle2D(): base()
        {
        }

        public Circle2D(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(radius);
            binaryWriter.Write(x);
            binaryWriter.Write(y);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            radius = binaryReader.ReadDouble();
            x = binaryReader.ReadDouble();
            y = binaryReader.ReadDouble();
        }
    }
}