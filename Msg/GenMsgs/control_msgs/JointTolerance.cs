namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/JointTolerance", "f544fe9c16cf04547e135dd6063ff5be", "# The tolerances specify the amount the position, velocity, and\n# accelerations can vary from the setpoints.  For example, in the case\n# of trajectory control, when the actual position varies beyond\n# (desired position + position tolerance), the trajectory goal may\n# abort.\n# \n# There are two special values for tolerances:\n#  * 0 - The tolerance is unspecified and will remain at whatever the default is\n#  * -1 - The tolerance is \"erased\".  If there was a default, the joint will be\n#         allowed to move without restriction.\n\nstring name\nfloat64 position  # in radians or meters (for a revolute or prismatic joint, respectively)\nfloat64 velocity  # in rad/sec or m/sec\nfloat64 acceleration  # in rad/sec^2 or m/sec^2\n")]
    public partial class JointTolerance : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.Double position
        {
            get;
            set;
        }

        public System.Double velocity
        {
            get;
            set;
        }

        public System.Double acceleration
        {
            get;
            set;
        }

        public JointTolerance(): base()
        {
        }

        public JointTolerance(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(position);
            binaryWriter.Write(velocity);
            binaryWriter.Write(acceleration);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            position = binaryReader.ReadDouble();
            velocity = binaryReader.ReadDouble();
            acceleration = binaryReader.ReadDouble();
        }
    }
}