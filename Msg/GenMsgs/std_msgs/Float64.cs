namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Float64", "fdb28210bfa9d7c91146260178d9a584", "float64 data")]
    public partial class Float64 : RosMsg
    {
        public System.Double data
        {
            get;
            set;
        }

        public Float64(): base()
        {
        }

        public Float64(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadDouble();
        }
    }
}