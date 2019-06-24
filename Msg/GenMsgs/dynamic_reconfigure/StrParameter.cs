namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/StrParameter", "bc6ccc4a57f61779c8eaae61e9f422e0", @"string name
string value
")]
    public partial class StrParameter : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.String value
        {
            get;
            set;
        }

        public StrParameter(): base()
        {
        }

        public StrParameter(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(value.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( value ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            value = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}