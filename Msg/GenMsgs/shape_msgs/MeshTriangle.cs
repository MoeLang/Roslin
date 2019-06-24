namespace Roslin.Msg.shape_msgs
{
    [MsgInfo("shape_msgs/MeshTriangle", "23688b2e6d2de3d32fe8af104a903253", @"# Definition of a triangle's vertices
uint32[3] vertex_indices
")]
    public partial class MeshTriangle : RosMsg
    {
        public System.UInt32[] vertex_indices
        {
            get;
            set;
        }

        public MeshTriangle(): base()
        {
        }

        public MeshTriangle(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            for (int i = 0; i < 3; i++)
                binaryWriter.Write(vertex_indices[i]);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            vertex_indices = new System.UInt32[3]; for  ( int  i  =  0 ;  i < 3 ;  i ++ ) vertex_indices [ i ]  =  binaryReader . ReadUInt32 ( ) ; 
        }
    }
}