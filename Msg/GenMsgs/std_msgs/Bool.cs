namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Bool", "8b94c1b53db61fb6aed406028ad6332a", "bool data")]
    public partial class Bool : RosMsg
    {
        public System.Boolean data
        {
            get;
            set;
        }

        public Bool(): base()
        {
        }

        public Bool(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadBoolean();
        }
    }
}