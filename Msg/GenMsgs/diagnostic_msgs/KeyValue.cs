namespace Roslin.Msg.diagnostic_msgs
{
    [MsgInfo("diagnostic_msgs/KeyValue", "cf57fdc6617a881a88c16e768132149c", "string key # what to label this value when viewing\nstring value # a value to track over time\n")]
    public partial class KeyValue : RosMsg
    {
        public System.String key
        {
            get;
            set;
        }

        public System.String value
        {
            get;
            set;
        }

        public KeyValue(): base()
        {
        }

        public KeyValue(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(key.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( key ) ) ; 
            binaryWriter.Write(value.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( value ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            key = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            value = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}