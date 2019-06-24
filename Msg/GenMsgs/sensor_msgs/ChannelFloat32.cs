namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/ChannelFloat32", "3d40139cdd33dfedcb71ffeeeb42ae7f", @"# This message is used by the PointCloud message to hold optional data
# associated with each point in the cloud. The length of the values
# array should be the same as the length of the points array in the
# PointCloud, and each value should be associated with the corresponding
# point.

# Channel names in existing practice include:
#   ""u"", ""v"" - row and column (respectively) in the left stereo image.
#              This is opposite to usual conventions but remains for
#              historical reasons. The newer PointCloud2 message has no
#              such problem.
#   ""rgb"" - For point clouds produced by color stereo cameras. uint8
#           (R,G,B) values packed into the least significant 24 bits,
#           in order.
#   ""intensity"" - laser or pixel intensity.
#   ""distance""

# The channel name should give semantics of the channel (e.g.
# ""intensity"" instead of ""value"").
string name

# The values array should be 1-1 with the elements of the associated
# PointCloud.
float32[] values
")]
    public partial class ChannelFloat32 : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.Single[] values
        {
            get;
            set;
        }

        public ChannelFloat32(): base()
        {
        }

        public ChannelFloat32(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(values.Length); for  ( int  i  =  0 ;  i < values . Length ;  i ++ ) binaryWriter . Write ( values [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            values = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < values . Length ;  i ++ ) values [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}