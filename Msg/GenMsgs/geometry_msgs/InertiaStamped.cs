namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/InertiaStamped", "ddee48caeab5a966c5e8d166654a9ac7", @"Header header
Inertia inertia
")]
    public partial class InertiaStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Inertia inertia
        {
            get;
            set;
        }

        public InertiaStamped(): base()
        {
        }

        public InertiaStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            inertia.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            inertia = new Inertia(binaryReader);
        }
    }
}