namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ModelCoefficientsArray", "059efee897c3f4ae027a493e30c4c26b", @"# ModelCoefficientsArray is used to represent coefficients of model
# for each segmented clusters.
# Simply put, ModelCoefficientsArray is a list of ModelCoefficients.
Header header
pcl_msgs/ModelCoefficients[] coefficients
")]
    public partial class ModelCoefficientsArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public pcl_msgs.ModelCoefficients[] coefficients
        {
            get;
            set;
        }

        public ModelCoefficientsArray(): base()
        {
        }

        public ModelCoefficientsArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(coefficients.Length); for  ( int  i  =  0 ;  i < coefficients . Length ;  i ++ ) coefficients [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            coefficients = new pcl_msgs.ModelCoefficients[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < coefficients . Length ;  i ++ ) coefficients [ i ]  =  new  pcl_msgs . ModelCoefficients ( binaryReader ) ; 
        }
    }
}