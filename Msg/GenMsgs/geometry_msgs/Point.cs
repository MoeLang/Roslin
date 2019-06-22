namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Point", "4a842b65f413084dc2b10fb484ea7f17", "# This contains the position of a point in free space\nfloat64 x\nfloat64 y\nfloat64 z\n")]
    public partial class Point : RosMsg
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

        public System.Double z
        {
            get;
            set;
        }

        public Point(): base()
        {
        }

        public Point(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(z);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            x = binaryReader.ReadDouble();
            y = binaryReader.ReadDouble();
            z = binaryReader.ReadDouble();
        }
    }
}