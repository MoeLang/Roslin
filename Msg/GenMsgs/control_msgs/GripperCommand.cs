namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/GripperCommand", "680acaff79486f017132a7f198d40f08", "float64 position\nfloat64 max_effort\n")]
    public partial class GripperCommand : RosMsg
    {
        public System.Double position
        {
            get;
            set;
        }

        public System.Double max_effort
        {
            get;
            set;
        }

        public GripperCommand(): base()
        {
        }

        public GripperCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(position);
            binaryWriter.Write(max_effort);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            position = binaryReader.ReadDouble();
            max_effort = binaryReader.ReadDouble();
        }
    }
}