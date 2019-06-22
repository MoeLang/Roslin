namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/TwistWithCovariance", "1fe8a28e6890a4cc3ae4c3ca5c7d82e6", "# This expresses velocity in free space with uncertainty.\n\nTwist twist\n\n# Row-major representation of the 6x6 covariance matrix\n# The orientation parameters use a fixed-axis representation.\n# In order, the parameters are:\n# (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)\nfloat64[36] covariance\n")]
    public partial class TwistWithCovariance : RosMsg
    {
        public Twist twist
        {
            get;
            set;
        }

        public System.Double[] covariance
        {
            get;
            set;
        }

        public TwistWithCovariance(): base()
        {
        }

        public TwistWithCovariance(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            twist.Serilize(binaryWriter);
            for (int i = 0; i < 36; i++)
                binaryWriter.Write(covariance[i]);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            twist = new Twist(binaryReader);
            covariance = new System.Double[36]; for  ( int  i  =  0 ;  i < 36 ;  i ++ ) covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}