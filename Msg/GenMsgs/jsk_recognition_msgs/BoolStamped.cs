namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/BoolStamped", "542e22b190dc8e6eb476d50dda88feb7", "Header header\nbool data\n")]
    public partial class BoolStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean data
        {
            get;
            set;
        }

        public BoolStamped(): base()
        {
        }

        public BoolStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            data = binaryReader.ReadBoolean();
        }
    }
}