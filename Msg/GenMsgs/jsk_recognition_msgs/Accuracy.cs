namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Accuracy", "198da9dc2684aac2aa03a85a3344f5ef", @"Header header
float32 accuracy
")]
    public partial class Accuracy : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single accuracy
        {
            get;
            set;
        }

        public Accuracy(): base()
        {
        }

        public Accuracy(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(accuracy);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            accuracy = binaryReader.ReadSingle();
        }
    }
}