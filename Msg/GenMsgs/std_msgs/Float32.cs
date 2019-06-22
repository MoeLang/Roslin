namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Float32", "73fcbf46b49191e672908e50842a83d4", "float32 data")]
    public partial class Float32 : RosMsg
    {
        public System.Single data
        {
            get;
            set;
        }

        public Float32(): base()
        {
        }

        public Float32(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadSingle();
        }
    }
}