namespace Roslin.Msg.map_msgs
{
    [MsgInfo("map_msgs/PointCloud2Update", "6c58e4f249ae9cd2b24fb1ee0f99195e", "uint32 ADD=0\nuint32 DELETE=1\nHeader header\nuint32 type          # type of update, one of ADD or DELETE\nsensor_msgs/PointCloud2 points\n")]
    public partial class PointCloud2Update : RosMsg
    {
        public System.UInt32 ADD => 0;
        public System.UInt32 DELETE => 1;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt32 type
        {
            get;
            set;
        }

        public sensor_msgs.PointCloud2 points
        {
            get;
            set;
        }

        public PointCloud2Update(): base()
        {
        }

        public PointCloud2Update(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(type);
            points.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            type = binaryReader.ReadUInt32();
            points = new sensor_msgs.PointCloud2(binaryReader);
        }
    }
}