namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SnapItRequest", "5733f480694296678d81cff0483b399b", @"Header header
uint8 MODEL_PLANE=0
uint8 MODEL_CYLINDER=1
uint8 model_type

geometry_msgs/PolygonStamped target_plane

geometry_msgs/PointStamped center
geometry_msgs/Vector3Stamped direction
float64 radius
float64 height
# parameters, 0 means 
float64 max_distance
float64 eps_angle
")]
    public partial class SnapItRequest : RosMsg
    {
        public System.Byte MODEL_PLANE => 0;
        public System.Byte MODEL_CYLINDER => 1;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Byte model_type
        {
            get;
            set;
        }

        public geometry_msgs.PolygonStamped target_plane
        {
            get;
            set;
        }

        public geometry_msgs.PointStamped center
        {
            get;
            set;
        }

        public geometry_msgs.Vector3Stamped direction
        {
            get;
            set;
        }

        public System.Double radius
        {
            get;
            set;
        }

        public System.Double height
        {
            get;
            set;
        }

        public System.Double max_distance
        {
            get;
            set;
        }

        public System.Double eps_angle
        {
            get;
            set;
        }

        public SnapItRequest(): base()
        {
        }

        public SnapItRequest(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(model_type);
            target_plane.Serilize(binaryWriter);
            center.Serilize(binaryWriter);
            direction.Serilize(binaryWriter);
            binaryWriter.Write(radius);
            binaryWriter.Write(height);
            binaryWriter.Write(max_distance);
            binaryWriter.Write(eps_angle);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            model_type = binaryReader.ReadByte();
            target_plane = new geometry_msgs.PolygonStamped(binaryReader);
            center = new geometry_msgs.PointStamped(binaryReader);
            direction = new geometry_msgs.Vector3Stamped(binaryReader);
            radius = binaryReader.ReadDouble();
            height = binaryReader.ReadDouble();
            max_distance = binaryReader.ReadDouble();
            eps_angle = binaryReader.ReadDouble();
        }
    }
}