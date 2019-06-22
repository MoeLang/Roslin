namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/AccelWithCovariance", "ad5a718d699c6be72a02b8d6a139f334", "# This expresses acceleration in free space with uncertainty.\n\nAccel accel\n\n# Row-major representation of the 6x6 covariance matrix\n# The orientation parameters use a fixed-axis representation.\n# In order, the parameters are:\n# (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)\nfloat64[36] covariance\n")]
    public partial class AccelWithCovariance : RosMsg
    {
        public Accel accel
        {
            get;
            set;
        }

        public System.Double[] covariance
        {
            get;
            set;
        }

        public AccelWithCovariance(): base()
        {
        }

        public AccelWithCovariance(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            accel.Serilize(binaryWriter);
            for (int i = 0; i < 36; i++)
                binaryWriter.Write(covariance[i]);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            accel = new Accel(binaryReader);
            covariance = new System.Double[36]; for  ( int  i  =  0 ;  i < 36 ;  i ++ ) covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}