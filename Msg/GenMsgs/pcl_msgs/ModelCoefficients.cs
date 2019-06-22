namespace Roslin.Msg.pcl_msgs
{
    [MsgInfo("pcl_msgs/ModelCoefficients", "ca27dea75e72cb894cd36f9e5005e93e", "Header header\nfloat32[] values\n\n")]
    public partial class ModelCoefficients : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single[] values
        {
            get;
            set;
        }

        public ModelCoefficients(): base()
        {
        }

        public ModelCoefficients(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(values.Length); for  ( int  i  =  0 ;  i < values . Length ;  i ++ ) binaryWriter . Write ( values [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            values = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < values . Length ;  i ++ ) values [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}