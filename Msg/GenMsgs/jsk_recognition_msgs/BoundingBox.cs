namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/BoundingBox", "f4b35de043f6031fe29bcfe43eeb9dca", "# BoundingBox represents a oriented bounding box.\nHeader header\ngeometry_msgs/Pose pose\ngeometry_msgs/Vector3 dimensions  # size of bounding box (x, y, z)\n# You can use this field to hold value such as likelihood\nfloat32 value\nuint32 label\n")]
    public partial class BoundingBox : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 dimensions
        {
            get;
            set;
        }

        public System.Single value
        {
            get;
            set;
        }

        public System.UInt32 label
        {
            get;
            set;
        }

        public BoundingBox(): base()
        {
        }

        public BoundingBox(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            pose.Serilize(binaryWriter);
            dimensions.Serilize(binaryWriter);
            binaryWriter.Write(value);
            binaryWriter.Write(label);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            pose = new geometry_msgs.Pose(binaryReader);
            dimensions = new geometry_msgs.Vector3(binaryReader);
            value = binaryReader.ReadSingle();
            label = binaryReader.ReadUInt32();
        }
    }
}