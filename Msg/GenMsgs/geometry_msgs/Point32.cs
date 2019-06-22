namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Point32", "cc153912f1453b708d221682bc23d9ac", "# This contains the position of a point in free space(with 32 bits of precision).\n# It is recommeded to use Point wherever possible instead of Point32.  \n# \n# This recommendation is to promote interoperability.  \n#\n# This message is designed to take up less space when sending\n# lots of points at once, as in the case of a PointCloud.  \n\nfloat32 x\nfloat32 y\nfloat32 z")]
    public partial class Point32 : RosMsg
    {
        public System.Single x
        {
            get;
            set;
        }

        public System.Single y
        {
            get;
            set;
        }

        public System.Single z
        {
            get;
            set;
        }

        public Point32(): base()
        {
        }

        public Point32(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            x = binaryReader.ReadSingle();
            y = binaryReader.ReadSingle();
            z = binaryReader.ReadSingle();
        }
    }
}