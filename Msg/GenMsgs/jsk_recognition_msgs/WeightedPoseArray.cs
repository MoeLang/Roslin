namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/WeightedPoseArray", "40f180494a75a8797b1c2ba81b2cb4c0", "Header header\nfloat32[] weights\ngeometry_msgs/PoseArray poses\n")]
    public partial class WeightedPoseArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single[] weights
        {
            get;
            set;
        }

        public geometry_msgs.PoseArray poses
        {
            get;
            set;
        }

        public WeightedPoseArray(): base()
        {
        }

        public WeightedPoseArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(weights.Length); for  ( int  i  =  0 ;  i < weights . Length ;  i ++ ) binaryWriter . Write ( weights [ i ] ) ; 
            poses.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            weights = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < weights . Length ;  i ++ ) weights [ i ]  =  binaryReader . ReadSingle ( ) ; 
            poses = new geometry_msgs.PoseArray(binaryReader);
        }
    }
}