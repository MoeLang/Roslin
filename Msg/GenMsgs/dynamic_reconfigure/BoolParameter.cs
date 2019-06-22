namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/BoolParameter", "23f05028c1a699fb83e22401228c3a9e", "string name\nbool value\n")]
    public partial class BoolParameter : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.Boolean value
        {
            get;
            set;
        }

        public BoolParameter(): base()
        {
        }

        public BoolParameter(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            value = binaryReader.ReadBoolean();
        }
    }
}