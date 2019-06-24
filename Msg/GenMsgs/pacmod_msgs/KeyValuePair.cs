namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/KeyValuePair", "cf57fdc6617a881a88c16e768132149c", @"string key
string value
")]
    public partial class KeyValuePair : RosMsg
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

        public KeyValuePair(): base()
        {
        }

        public KeyValuePair(System.IO.BinaryReader binaryReader): base(binaryReader)
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