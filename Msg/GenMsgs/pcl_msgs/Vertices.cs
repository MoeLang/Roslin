namespace Roslin.Msg.pcl_msgs
{
    [MsgInfo("pcl_msgs/Vertices", "39bd7b1c23763ddd1b882b97cb7cfe11", @"# List of point indices
uint32[] vertices
")]
    public partial class Vertices : RosMsg
    {
        public System.UInt32[] vertices
        {
            get;
            set;
        }

        public Vertices(): base()
        {
        }

        public Vertices(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(vertices.Length); for  ( int  i  =  0 ;  i < vertices . Length ;  i ++ ) binaryWriter . Write ( vertices [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            vertices = new System.UInt32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < vertices . Length ;  i ++ ) vertices [ i ]  =  binaryReader . ReadUInt32 ( ) ; 
        }
    }
}