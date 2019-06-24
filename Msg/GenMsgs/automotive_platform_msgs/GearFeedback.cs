namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/GearFeedback", "328d639d4b37a5731de132f4aeb55699", @"# Current Gear Feedback

std_msgs/Header header

automotive_platform_msgs/Gear current_gear
")]
    public partial class GearFeedback : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public automotive_platform_msgs.Gear current_gear
        {
            get;
            set;
        }

        public GearFeedback(): base()
        {
        }

        public GearFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            current_gear.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            current_gear = new automotive_platform_msgs.Gear(binaryReader);
        }
    }
}