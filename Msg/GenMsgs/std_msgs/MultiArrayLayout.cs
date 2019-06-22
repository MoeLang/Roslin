namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/MultiArrayLayout", "0fed2a11c13e11c5571b4e2a995a91a3", "# The multiarray declares a generic multi-dimensional array of a\n# particular data type.  Dimensions are ordered from outer most\n# to inner most.\n\nMultiArrayDimension[] dim # Array of dimension properties\nuint32 data_offset        # padding elements at front of data\n\n# Accessors should ALWAYS be written in terms of dimension stride\n# and specified outer-most dimension first.\n# \n# multiarray(i,j,k) = data[data_offset + dim_stride[1]*i + dim_stride[2]*j + k]\n#\n# A standard, 3-channel 640x480 image with interleaved color channels\n# would be specified as:\n#\n# dim[0].label  = \"height\"\n# dim[0].size   = 480\n# dim[0].stride = 3*640*480 = 921600  (note dim[0] stride is just size of image)\n# dim[1].label  = \"width\"\n# dim[1].size   = 640\n# dim[1].stride = 3*640 = 1920\n# dim[2].label  = \"channel\"\n# dim[2].size   = 3\n# dim[2].stride = 3\n#\n# multiarray(i,j,k) refers to the ith row, jth column, and kth channel.\n")]
    public partial class MultiArrayLayout : RosMsg
    {
        public MultiArrayDimension[] dim
        {
            get;
            set;
        }

        public System.UInt32 data_offset
        {
            get;
            set;
        }

        public MultiArrayLayout(): base()
        {
        }

        public MultiArrayLayout(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(dim.Length); for  ( int  i  =  0 ;  i < dim . Length ;  i ++ ) dim [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(data_offset);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            dim = new MultiArrayDimension[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < dim . Length ;  i ++ ) dim [ i ]  =  new  MultiArrayDimension ( binaryReader ) ; 
            data_offset = binaryReader.ReadUInt32();
        }
    }
}