namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/LaserEcho", "8bc5ae449b200fba4d552b4225586696", @"# This message is a submessage of MultiEchoLaserScan and is not intended
# to be used separately.

float32[] echoes  # Multiple values of ranges or intensities.
                  # Each array represents data from the same angle increment.")]
    public partial class LaserEcho : RosMsg
    {
        public System.Single[] echoes
        {
            get;
            set;
        }

        public LaserEcho(): base()
        {
        }

        public LaserEcho(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(echoes.Length); for  ( int  i  =  0 ;  i < echoes . Length ;  i ++ ) binaryWriter . Write ( echoes [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            echoes = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < echoes . Length ;  i ++ ) echoes [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}