namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/GearCommand", "a95429508de6e31c2134277c47838158", @"# Current Gear Command

std_msgs/Header header

automotive_platform_msgs/Gear command
")]
    public partial class GearCommand : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public automotive_platform_msgs.Gear command
        {
            get;
            set;
        }

        public GearCommand(): base()
        {
        }

        public GearCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            command.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            command = new automotive_platform_msgs.Gear(binaryReader);
        }
    }
}