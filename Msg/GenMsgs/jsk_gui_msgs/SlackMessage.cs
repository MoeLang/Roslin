namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/SlackMessage", "b68991d3b722980bd0f3eeeeee52635b", @"string channel           # channel to post (ex. @user, #general)
string text              # text to post
sensor_msgs/Image image  # image to upload
")]
    public partial class SlackMessage : RosMsg
    {
        public System.String channel
        {
            get;
            set;
        }

        public System.String text
        {
            get;
            set;
        }

        public sensor_msgs.Image image
        {
            get;
            set;
        }

        public SlackMessage(): base()
        {
        }

        public SlackMessage(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(channel.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( channel ) ) ; 
            binaryWriter.Write(text.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( text ) ) ; 
            image.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            channel = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            text = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            image = new sensor_msgs.Image(binaryReader);
        }
    }
}