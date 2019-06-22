namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ClusterPointIndices", "d43e94ea5e491effac7685a42b7b9d14", "# ClusterPointIndices is used to represent segmentation result.\n# Simply put, ClusterPointIndices is a list of PointIndices.\nHeader header\npcl_msgs/PointIndices[] cluster_indices\n")]
    public partial class ClusterPointIndices : RosMsg
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

        public ClusterPointIndices(): base()
        {
        }

        public ClusterPointIndices(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(cluster_indices.Length); for  ( int  i  =  0 ;  i < cluster_indices . Length ;  i ++ ) cluster_indices [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            cluster_indices = new pcl_msgs.PointIndices[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cluster_indices . Length ;  i ++ ) cluster_indices [ i ]  =  new  pcl_msgs . PointIndices ( binaryReader ) ; 
        }
    }
}