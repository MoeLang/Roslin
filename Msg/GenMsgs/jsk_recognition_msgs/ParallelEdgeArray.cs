namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ParallelEdgeArray", "7c8ef4f5976c55fb32293ceaa19a1189", @"Header header
ParallelEdge[] edge_groups
")]
    public partial class ParallelEdgeArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public ParallelEdge[] edge_groups
        {
            get;
            set;
        }

        public ParallelEdgeArray(): base()
        {
        }

        public ParallelEdgeArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(edge_groups.Length); for  ( int  i  =  0 ;  i < edge_groups . Length ;  i ++ ) edge_groups [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            edge_groups = new ParallelEdge[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < edge_groups . Length ;  i ++ ) edge_groups [ i ]  =  new  ParallelEdge ( binaryReader ) ; 
        }
    }
}