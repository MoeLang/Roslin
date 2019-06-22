namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Wrench", "4f539cf138b23283b520fd271b567936", "# This represents force in free space, separated into\n# its linear and angular parts.\nVector3  force\nVector3  torque\n")]
    public partial class Wrench : RosMsg
    {
        public Vector3 force
        {
            get;
            set;
        }

        public Vector3 torque
        {
            get;
            set;
        }

        public Wrench(): base()
        {
        }

        public Wrench(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            force.Serilize(binaryWriter);
            torque.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            force = new Vector3(binaryReader);
            torque = new Vector3(binaryReader);
        }
    }
}