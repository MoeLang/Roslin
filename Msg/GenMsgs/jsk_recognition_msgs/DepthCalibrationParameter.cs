namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/DepthCalibrationParameter", "d8318983ee0a76ad66ecf4b504350888", "# each vector stands for C(u, v)\n# C(u, v) = a_0 * u^2 + a_1 * u + a_2 * v^2 + a_3 * v + a_4\nfloat64[] coefficients2\nfloat64[] coefficients1\nfloat64[] coefficients0\nbool use_abs\n")]
    public partial class DepthCalibrationParameter : RosMsg
    {
        public System.Double[] coefficients2
        {
            get;
            set;
        }

        public System.Double[] coefficients1
        {
            get;
            set;
        }

        public System.Double[] coefficients0
        {
            get;
            set;
        }

        public System.Boolean use_abs
        {
            get;
            set;
        }

        public DepthCalibrationParameter(): base()
        {
        }

        public DepthCalibrationParameter(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(coefficients2.Length); for  ( int  i  =  0 ;  i < coefficients2 . Length ;  i ++ ) binaryWriter . Write ( coefficients2 [ i ] ) ; 
            binaryWriter.Write(coefficients1.Length); for  ( int  i  =  0 ;  i < coefficients1 . Length ;  i ++ ) binaryWriter . Write ( coefficients1 [ i ] ) ; 
            binaryWriter.Write(coefficients0.Length); for  ( int  i  =  0 ;  i < coefficients0 . Length ;  i ++ ) binaryWriter . Write ( coefficients0 [ i ] ) ; 
            binaryWriter.Write(use_abs);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            coefficients2 = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < coefficients2 . Length ;  i ++ ) coefficients2 [ i ]  =  binaryReader . ReadDouble ( ) ; 
            coefficients1 = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < coefficients1 . Length ;  i ++ ) coefficients1 [ i ]  =  binaryReader . ReadDouble ( ) ; 
            coefficients0 = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < coefficients0 . Length ;  i ++ ) coefficients0 [ i ]  =  binaryReader . ReadDouble ( ) ; 
            use_abs = binaryReader.ReadBoolean();
        }
    }
}