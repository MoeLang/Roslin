namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SlicedPointCloud", "37376a48b034bf543f8cfd86844487c7", "sensor_msgs/PointCloud2 point_cloud\nuint8 slice_index\nuint8 sequence_id\n")]
    public partial class SlicedPointCloud : RosMsg
    {
        public sensor_msgs.PointCloud2 point_cloud
        {
            get;
            set;
        }

        public System.Byte slice_index
        {
            get;
            set;
        }

        public System.Byte sequence_id
        {
            get;
            set;
        }

        public SlicedPointCloud(): base()
        {
        }

        public SlicedPointCloud(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            point_cloud.Serilize(binaryWriter);
            binaryWriter.Write(slice_index);
            binaryWriter.Write(sequence_id);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            point_cloud = new sensor_msgs.PointCloud2(binaryReader);
            slice_index = binaryReader.ReadByte();
            sequence_id = binaryReader.ReadByte();
        }
    }
}