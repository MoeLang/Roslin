namespace Roslin.Msg.posedetection_msgs
{
    [MsgInfo("posedetection_msgs/Curve1D", "e5367ca89dc9a58670f8f288e2c52f5d", @"float32[] pts # 2xN points in the image
")]
    public partial class Curve1D : RosMsg
    {
        public System.Single[] pts
        {
            get;
            set;
        }

        public Curve1D(): base()
        {
        }

        public Curve1D(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(pts.Length); for  ( int  i  =  0 ;  i < pts . Length ;  i ++ ) binaryWriter . Write ( pts [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            pts = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < pts . Length ;  i ++ ) pts [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}