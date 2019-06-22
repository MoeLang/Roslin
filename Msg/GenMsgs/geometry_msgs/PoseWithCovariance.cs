namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/PoseWithCovariance", "c23e848cf1b7533a8d7c259073a97e6f", "# This represents a pose in free space with uncertainty.\n\nPose pose\n\n# Row-major representation of the 6x6 covariance matrix\n# The orientation parameters use a fixed-axis representation.\n# In order, the parameters are:\n# (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)\nfloat64[36] covariance\n")]
    public partial class PoseWithCovariance : RosMsg
    {
        public Pose pose
        {
            get;
            set;
        }

        public System.Double[] covariance
        {
            get;
            set;
        }

        public PoseWithCovariance(): base()
        {
        }

        public PoseWithCovariance(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            pose.Serilize(binaryWriter);
            for (int i = 0; i < 36; i++)
                binaryWriter.Write(covariance[i]);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            pose = new Pose(binaryReader);
            covariance = new System.Double[36]; for  ( int  i  =  0 ;  i < 36 ;  i ++ ) covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}