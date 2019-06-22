namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SparseOccupancyGridArray", "fa9a1f59b783128c759e159dd0c46731", "Header header\nSparseOccupancyGrid[] grids\n")]
    public partial class SparseOccupancyGridArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public SparseOccupancyGrid[] grids
        {
            get;
            set;
        }

        public SparseOccupancyGridArray(): base()
        {
        }

        public SparseOccupancyGridArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(grids.Length); for  ( int  i  =  0 ;  i < grids . Length ;  i ++ ) grids [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            grids = new SparseOccupancyGrid[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < grids . Length ;  i ++ ) grids [ i ]  =  new  SparseOccupancyGrid ( binaryReader ) ; 
        }
    }
}