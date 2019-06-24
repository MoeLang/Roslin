namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/PointCloud2", "1158d486dd51d683ce2f1be655c3c181", @"# This message holds a collection of N-dimensional points, which may
# contain additional information such as normals, intensity, etc. The
# point data is stored as a binary blob, its layout described by the
# contents of the ""fields"" array.

# The point cloud data may be organized 2d (image-like) or 1d
# (unordered). Point clouds organized as 2d images may be produced by
# camera depth sensors such as stereo or time-of-flight.

# Time of sensor data acquisition, and the coordinate frame ID (for 3d
# points).
Header header

# 2D structure of the point cloud. If the cloud is unordered, height is
# 1 and width is the length of the point cloud.
uint32 height
uint32 width

# Describes the channels and their layout in the binary data blob.
PointField[] fields

bool    is_bigendian # Is this data bigendian?
uint32  point_step   # Length of a point in bytes
uint32  row_step     # Length of a row in bytes
uint8[] data         # Actual point data, size is (row_step*height)

bool is_dense        # True if there are no invalid points
")]
    public partial class PointCloud2 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt32 height
        {
            get;
            set;
        }

        public System.UInt32 width
        {
            get;
            set;
        }

        public PointField[] fields
        {
            get;
            set;
        }

        public System.Boolean is_bigendian
        {
            get;
            set;
        }

        public System.UInt32 point_step
        {
            get;
            set;
        }

        public System.UInt32 row_step
        {
            get;
            set;
        }

        public System.Byte[] data
        {
            get;
            set;
        }

        public System.Boolean is_dense
        {
            get;
            set;
        }

        public PointCloud2(): base()
        {
        }

        public PointCloud2(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(height);
            binaryWriter.Write(width);
            binaryWriter.Write(fields.Length); for  ( int  i  =  0 ;  i < fields . Length ;  i ++ ) fields [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(is_bigendian);
            binaryWriter.Write(point_step);
            binaryWriter.Write(row_step);
            binaryWriter.Write(data.Length); binaryWriter . Write ( data ) ; 
            binaryWriter.Write(is_dense);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            height = binaryReader.ReadUInt32();
            width = binaryReader.ReadUInt32();
            fields = new PointField[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < fields . Length ;  i ++ ) fields [ i ]  =  new  PointField ( binaryReader ) ; 
            is_bigendian = binaryReader.ReadBoolean();
            point_step = binaryReader.ReadUInt32();
            row_step = binaryReader.ReadUInt32();
            data = new System.Byte[binaryReader.ReadInt32()]; data  =  binaryReader . ReadBytes ( data . Length ) ; 
            is_dense = binaryReader.ReadBoolean();
        }
    }
}