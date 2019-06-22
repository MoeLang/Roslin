namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/BrakeCommand", "2e19ae4283bff8e4baca0a8af4d4961e", "# Current Brake Pedal Command\n\nstd_msgs/Header header\n\nfloat32 brake_pedal     # 0 to 1.0\n\n\n")]
    public partial class BrakeCommand : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single brake_pedal
        {
            get;
            set;
        }

        public BrakeCommand(): base()
        {
        }

        public BrakeCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(brake_pedal);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            brake_pedal = binaryReader.ReadSingle();
        }
    }
}