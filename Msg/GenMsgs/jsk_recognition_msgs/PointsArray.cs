namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/PointsArray", "0aa7e57c9da77fc1a0d8277bba5672b1", @"Header header
sensor_msgs/PointCloud2[] cloud_list
")]
    public partial class PointsArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public sensor_msgs.PointCloud2[] cloud_list
        {
            get;
            set;
        }

        public PointsArray(): base()
        {
        }

        public PointsArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(cloud_list.Length); for  ( int  i  =  0 ;  i < cloud_list . Length ;  i ++ ) cloud_list [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            cloud_list = new sensor_msgs.PointCloud2[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cloud_list . Length ;  i ++ ) cloud_list [ i ]  =  new  sensor_msgs . PointCloud2 ( binaryReader ) ; 
        }
    }
}