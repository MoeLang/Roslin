namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Int32Stamped", "e7344a45486eefa24d2f337265df37ce", "Header header\nint32 data\n")]
    public partial class Int32Stamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Int32 data
        {
            get;
            set;
        }

        public Int32Stamped(): base()
        {
        }

        public Int32Stamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            data = binaryReader.ReadInt32();
        }
    }
}