namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/DoubleParameter", "d8512f27253c0f65f928a67c329cd658", "string name\nfloat64 value\n")]
    public partial class DoubleParameter : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.Double value
        {
            get;
            set;
        }

        public DoubleParameter(): base()
        {
        }

        public DoubleParameter(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(value);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            value = binaryReader.ReadDouble();
        }
    }
}