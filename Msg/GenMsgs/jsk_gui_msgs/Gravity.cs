namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/Gravity", "86facaf836997cbbc4faee170616f59e", @"geometry_msgs/Vector3 gravity")]
    public partial class Gravity : RosMsg
    {
        public geometry_msgs.Vector3 gravity
        {
            get;
            set;
        }

        public Gravity(): base()
        {
        }

        public Gravity(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            gravity.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            gravity = new geometry_msgs.Vector3(binaryReader);
        }
    }
}