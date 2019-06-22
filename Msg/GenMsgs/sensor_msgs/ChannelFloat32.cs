namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/ChannelFloat32", "3d40139cdd33dfedcb71ffeeeb42ae7f", "# This message is used by the PointCloud message to hold optional data\n# associated with each point in the cloud. The length of the values\n# array should be the same as the length of the points array in the\n# PointCloud, and each value should be associated with the corresponding\n# point.\n\n# Channel names in existing practice include:\n#   \"u\", \"v\" - row and column (respectively) in the left stereo image.\n#              This is opposite to usual conventions but remains for\n#              historical reasons. The newer PointCloud2 message has no\n#              such problem.\n#   \"rgb\" - For point clouds produced by color stereo cameras. uint8\n#           (R,G,B) values packed into the least significant 24 bits,\n#           in order.\n#   \"intensity\" - laser or pixel intensity.\n#   \"distance\"\n\n# The channel name should give semantics of the channel (e.g.\n# \"intensity\" instead of \"value\").\nstring name\n\n# The values array should be 1-1 with the elements of the associated\n# PointCloud.\nfloat32[] values\n")]
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