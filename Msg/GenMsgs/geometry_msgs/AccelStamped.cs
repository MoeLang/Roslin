namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/AccelStamped", "d8a98a5d81351b6eb0578c78557e7659", @"# An accel with reference coordinate frame and timestamp
Header header
Accel accel
")]
    public partial class AccelStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Accel accel
        {
            get;
            set;
        }

        public AccelStamped(): base()
        {
        }

        public AccelStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            accel.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            accel = new Accel(binaryReader);
        }
    }
}