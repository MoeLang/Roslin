namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SparseOccupancyGridColumn", "55074b193e722d5ead092ffe27f06522", @"int32 column_index
SparseOccupancyGridCell[] cells
")]
    public partial class SparseOccupancyGridColumn : RosMsg
    {
        public System.Int32 column_index
        {
            get;
            set;
        }

        public SparseOccupancyGridCell[] cells
        {
            get;
            set;
        }

        public SparseOccupancyGridColumn(): base()
        {
        }

        public SparseOccupancyGridColumn(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(column_index);
            binaryWriter.Write(cells.Length); for  ( int  i  =  0 ;  i < cells . Length ;  i ++ ) cells [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            column_index = binaryReader.ReadInt32();
            cells = new SparseOccupancyGridCell[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cells . Length ;  i ++ ) cells [ i ]  =  new  SparseOccupancyGridCell ( binaryReader ) ; 
        }
    }
}