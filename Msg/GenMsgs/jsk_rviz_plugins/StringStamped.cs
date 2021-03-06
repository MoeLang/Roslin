namespace Roslin.Msg.jsk_rviz_plugins
{
    [MsgInfo("jsk_rviz_plugins/StringStamped", "c99a9440709e4d4a9716d55b8270d5e7", @"Header header
string data

")]
    public partial class StringStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String data
        {
            get;
            set;
        }

        public StringStamped(): base()
        {
        }

        public StringStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(data.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( data ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            data = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}