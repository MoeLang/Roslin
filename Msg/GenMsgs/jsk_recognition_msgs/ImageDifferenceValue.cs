namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ImageDifferenceValue", "80b6f355db87c1b2d8b04d2f620fe0a7", @"Header header

float32 difference
")]
    public partial class ImageDifferenceValue : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single difference
        {
            get;
            set;
        }

        public ImageDifferenceValue(): base()
        {
        }

        public ImageDifferenceValue(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(difference);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            difference = binaryReader.ReadSingle();
        }
    }
}