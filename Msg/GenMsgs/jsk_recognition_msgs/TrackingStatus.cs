namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/TrackingStatus", "2e374cd736cf06cc3e69b0c76b8cb117", "Header header\n\n# if true, it means the tracker abandon to track the object.\nbool is_lost\n")]
    public partial class TrackingStatus : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean is_lost
        {
            get;
            set;
        }

        public TrackingStatus(): base()
        {
        }

        public TrackingStatus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(is_lost);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            is_lost = binaryReader.ReadBoolean();
        }
    }
}