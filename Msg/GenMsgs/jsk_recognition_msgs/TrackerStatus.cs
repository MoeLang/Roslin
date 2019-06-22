namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/TrackerStatus", "78e8f06a6b728df052dd181bfcf6c26e", "Header header\n# if true, it means the tracker is trying to track object,\n# else, the tracker think scene is stable and no need to track\n# to save computational resource.\nbool is_tracking\n")]
    public partial class TrackerStatus : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean is_tracking
        {
            get;
            set;
        }

        public TrackerStatus(): base()
        {
        }

        public TrackerStatus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(is_tracking);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            is_tracking = binaryReader.ReadBoolean();
        }
    }
}