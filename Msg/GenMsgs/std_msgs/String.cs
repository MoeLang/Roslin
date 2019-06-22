namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/String", "992ce8a1687cec8c8bd883ec73ca41d1", "string data\n")]
    public partial class String : RosMsg
    {
        public System.String data
        {
            get;
            set;
        }

        public String(): base()
        {
        }

        public String(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( data ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}