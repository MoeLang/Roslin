namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Quaternion", "a779879fadf0160734f906b8c19c7004", "# This represents an orientation in free space in quaternion form.\n\nfloat64 x\nfloat64 y\nfloat64 z\nfloat64 w\n")]
    public partial class Quaternion : RosMsg
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

        public System.Double w
        {
            get;
            set;
        }

        public Quaternion(): base()
        {
        }

        public Quaternion(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(z);
            binaryWriter.Write(w);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            x = binaryReader.ReadDouble();
            y = binaryReader.ReadDouble();
            z = binaryReader.ReadDouble();
            w = binaryReader.ReadDouble();
        }
    }
}