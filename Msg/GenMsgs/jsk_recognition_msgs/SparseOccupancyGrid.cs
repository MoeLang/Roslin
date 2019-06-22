namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SparseOccupancyGrid", "497269ddab6058d0d4860f25dc49448f", "Header header\ngeometry_msgs/Pose origin_pose\nfloat32 resolution\n\nSparseOccupancyGridColumn[] columns\n")]
    public partial class SparseOccupancyGrid : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Pose origin_pose
        {
            get;
            set;
        }

        public System.Single resolution
        {
            get;
            set;
        }

        public SparseOccupancyGridColumn[] columns
        {
            get;
            set;
        }

        public SparseOccupancyGrid(): base()
        {
        }

        public SparseOccupancyGrid(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            origin_pose.Serilize(binaryWriter);
            binaryWriter.Write(resolution);
            binaryWriter.Write(columns.Length); for  ( int  i  =  0 ;  i < columns . Length ;  i ++ ) columns [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            origin_pose = new geometry_msgs.Pose(binaryReader);
            resolution = binaryReader.ReadSingle();
            columns = new SparseOccupancyGridColumn[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < columns . Length ;  i ++ ) columns [ i ]  =  new  SparseOccupancyGridColumn ( binaryReader ) ; 
        }
    }
}