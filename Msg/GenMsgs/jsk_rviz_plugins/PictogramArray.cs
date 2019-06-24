namespace Roslin.Msg.jsk_rviz_plugins
{
    [MsgInfo("jsk_rviz_plugins/PictogramArray", "bfdafbfcdf121aed91dae673b47ae3fe", @"Header header
Pictogram[] pictograms")]
    public partial class PictogramArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Pictogram[] pictograms
        {
            get;
            set;
        }

        public PictogramArray(): base()
        {
        }

        public PictogramArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(pictograms.Length); for  ( int  i  =  0 ;  i < pictograms . Length ;  i ++ ) pictograms [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            pictograms = new Pictogram[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < pictograms . Length ;  i ++ ) pictograms [ i ]  =  new  Pictogram ( binaryReader ) ; 
        }
    }
}