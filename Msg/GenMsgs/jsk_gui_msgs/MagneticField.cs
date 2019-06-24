namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/MagneticField", "a924df7c82a527d1b76508ed8354604b", @"geometry_msgs/Vector3 magneticfield")]
    public partial class MagneticField : RosMsg
    {
        public geometry_msgs.Vector3 magneticfield
        {
            get;
            set;
        }

        public MagneticField(): base()
        {
        }

        public MagneticField(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            magneticfield.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            magneticfield = new geometry_msgs.Vector3(binaryReader);
        }
    }
}