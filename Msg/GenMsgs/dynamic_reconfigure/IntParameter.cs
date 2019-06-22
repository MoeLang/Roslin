namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/IntParameter", "65fedc7a0cbfb8db035e46194a350bf1", "string name\nint32 value\n")]
    public partial class IntParameter : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.Int32 value
        {
            get;
            set;
        }

        public IntParameter(): base()
        {
        }

        public IntParameter(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            value = binaryReader.ReadInt32();
        }
    }
}