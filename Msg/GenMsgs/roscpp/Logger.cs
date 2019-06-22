namespace Roslin.Msg.roscpp
{
    [MsgInfo("roscpp/Logger", "a6069a2ff40db7bd32143dd66e1f408e", "string name\nstring level\n")]
    public partial class Logger : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.String level
        {
            get;
            set;
        }

        public Logger(): base()
        {
        }

        public Logger(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(level.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( level ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            level = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}