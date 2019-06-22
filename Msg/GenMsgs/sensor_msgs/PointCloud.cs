namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/PointCloud", "d8e9c3f5afbdd8a130fd1d2763945fca", "# This message holds a collection of 3d points, plus optional additional\n# information about each point.\n\n# Time of sensor data acquisition, coordinate frame ID.\nHeader header\n\n# Array of 3d points. Each Point32 should be interpreted as a 3d point\n# in the frame given in the header.\ngeometry_msgs/Point32[] points\n\n# Each channel should have the same number of elements as points array,\n# and the data in each channel should correspond 1:1 with each point.\n# Channel names in common practice are listed in ChannelFloat32.msg.\nChannelFloat32[] channels\n")]
    public partial class PointCloud : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Point32[] points
        {
            get;
            set;
        }

        public ChannelFloat32[] channels
        {
            get;
            set;
        }

        public PointCloud(): base()
        {
        }

        public PointCloud(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(points.Length); for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(channels.Length); for  ( int  i  =  0 ;  i < channels . Length ;  i ++ ) channels [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            points = new geometry_msgs.Point32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ]  =  new  geometry_msgs . Point32 ( binaryReader ) ; 
            channels = new ChannelFloat32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < channels . Length ;  i ++ ) channels [ i ]  =  new  ChannelFloat32 ( binaryReader ) ; 
        }
    }
}