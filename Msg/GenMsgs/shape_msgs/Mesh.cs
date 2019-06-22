namespace Roslin.Msg.shape_msgs
{
    [MsgInfo("shape_msgs/Mesh", "1ffdae9486cd3316a121c578b47a85cc", "# Definition of a mesh\n\n# list of triangles; the index values refer to positions in vertices[]\nMeshTriangle[] triangles\n\n# the actual vertices that make up the mesh\ngeometry_msgs/Point[] vertices\n")]
    public partial class Mesh : RosMsg
    {
        public MeshTriangle[] triangles
        {
            get;
            set;
        }

        public geometry_msgs.Point[] vertices
        {
            get;
            set;
        }

        public Mesh(): base()
        {
        }

        public Mesh(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(triangles.Length); for  ( int  i  =  0 ;  i < triangles . Length ;  i ++ ) triangles [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(vertices.Length); for  ( int  i  =  0 ;  i < vertices . Length ;  i ++ ) vertices [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            triangles = new MeshTriangle[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < triangles . Length ;  i ++ ) triangles [ i ]  =  new  MeshTriangle ( binaryReader ) ; 
            vertices = new geometry_msgs.Point[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < vertices . Length ;  i ++ ) vertices [ i ]  =  new  geometry_msgs . Point ( binaryReader ) ; 
        }
    }
}