namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Vector3", "4a842b65f413084dc2b10fb484ea7f17", "# This represents a vector in free space. \n# It is only meant to represent a direction. Therefore, it does not\n# make sense to apply a translation to it (e.g., when applying a \n# generic rigid transformation to a Vector3, tf2 will only apply the\n# rotation). If you want your data to be translatable too, use the\n# geometry_msgs/Point message instead.\n\nfloat64 x\nfloat64 y\nfloat64 z")]
    public partial class Vector3 : RosMsg
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

        public Vector3(): base()
        {
        }

        public Vector3(System.IO.BinaryReader binaryReader): base(binaryReader)
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