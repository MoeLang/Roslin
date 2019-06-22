namespace Roslin.Msg.pcl_msgs
{
    [MsgInfo("pcl_msgs/PolygonMesh", "45a5fc6ad2cde8489600a790acc9a38a", "# Separate header for the polygonal surface\nHeader header\n# Vertices of the mesh as a point cloud\nsensor_msgs/PointCloud2 cloud\n# List of polygons\nVertices[] polygons\n")]
    public partial class PolygonMesh : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public sensor_msgs.PointCloud2 cloud
        {
            get;
            set;
        }

        public Vertices[] polygons
        {
            get;
            set;
        }

        public PolygonMesh(): base()
        {
        }

        public PolygonMesh(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            cloud.Serilize(binaryWriter);
            binaryWriter.Write(polygons.Length); for  ( int  i  =  0 ;  i < polygons . Length ;  i ++ ) polygons [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            cloud = new sensor_msgs.PointCloud2(binaryReader);
            polygons = new Vertices[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < polygons . Length ;  i ++ ) polygons [ i ]  =  new  Vertices ( binaryReader ) ; 
        }
    }
}