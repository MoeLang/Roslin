namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/HistogramWithRangeBin", "a7fe6c3021fcba2c6357f3db21601551", "float64 min_value\nfloat64 max_value\nuint32 count\n")]
    public partial class HistogramWithRangeBin : RosMsg
    {
        public System.Double min_value
        {
            get;
            set;
        }

        public System.Double max_value
        {
            get;
            set;
        }

        public System.UInt32 count
        {
            get;
            set;
        }

        public HistogramWithRangeBin(): base()
        {
        }

        public HistogramWithRangeBin(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(min_value);
            binaryWriter.Write(max_value);
            binaryWriter.Write(count);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            min_value = binaryReader.ReadDouble();
            max_value = binaryReader.ReadDouble();
            count = binaryReader.ReadUInt32();
        }
    }
}