namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SparseOccupancyGridCell", "a5179e922852f82ee6322db1f097ab64", "int32 row_index\nfloat32 value\n")]
    public partial class SparseOccupancyGridCell : RosMsg
    {
        public System.Int32 row_index
        {
            get;
            set;
        }

        public System.Single value
        {
            get;
            set;
        }

        public SparseOccupancyGridCell(): base()
        {
        }

        public SparseOccupancyGridCell(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(row_index);
            binaryWriter.Write(value);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            row_index = binaryReader.ReadInt32();
            value = binaryReader.ReadSingle();
        }
    }
}