namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/WrenchStamped", "d78d3cb249ce23087ade7e7d0c40cfa7", "# A wrench with reference coordinate frame and timestamp\nHeader header\nWrench wrench\n")]
    public partial class WrenchStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Wrench wrench
        {
            get;
            set;
        }

        public WrenchStamped(): base()
        {
        }

        public WrenchStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            wrench.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            wrench = new Wrench(binaryReader);
        }
    }
}