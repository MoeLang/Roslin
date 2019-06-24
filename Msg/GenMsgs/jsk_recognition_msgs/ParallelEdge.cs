namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ParallelEdge", "3a550d5b6275fe0a1580ebf8a62dd336", @"Header header
pcl_msgs/PointIndices[] cluster_indices
pcl_msgs/ModelCoefficients[] coefficients
")]
    public partial class ParallelEdge : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public pcl_msgs.PointIndices[] cluster_indices
        {
            get;
            set;
        }

        public pcl_msgs.ModelCoefficients[] coefficients
        {
            get;
            set;
        }

        public ParallelEdge(): base()
        {
        }

        public ParallelEdge(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(cluster_indices.Length); for  ( int  i  =  0 ;  i < cluster_indices . Length ;  i ++ ) cluster_indices [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(coefficients.Length); for  ( int  i  =  0 ;  i < coefficients . Length ;  i ++ ) coefficients [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            cluster_indices = new pcl_msgs.PointIndices[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cluster_indices . Length ;  i ++ ) cluster_indices [ i ]  =  new  pcl_msgs . PointIndices ( binaryReader ) ; 
            coefficients = new pcl_msgs.ModelCoefficients[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < coefficients . Length ;  i ++ ) coefficients [ i ]  =  new  pcl_msgs . ModelCoefficients ( binaryReader ) ; 
        }
    }
}