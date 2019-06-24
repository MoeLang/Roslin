namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/MarkerArray", "d155b9ce5188fbaf89745847fd5882d7", @"Marker[] markers
")]
    public partial class MarkerArray : RosMsg
    {
        public Marker[] markers
        {
            get;
            set;
        }

        public MarkerArray(): base()
        {
        }

        public MarkerArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(markers.Length); for  ( int  i  =  0 ;  i < markers . Length ;  i ++ ) markers [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            markers = new Marker[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < markers . Length ;  i ++ ) markers [ i ]  =  new  Marker ( binaryReader ) ; 
        }
    }
}