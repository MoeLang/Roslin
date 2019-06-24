namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Accel", "9f195f881246fdfa2798d1d3eebca84a", @"# This expresses acceleration in free space broken into its linear and angular parts.
Vector3  linear
Vector3  angular
")]
    public partial class Accel : RosMsg
    {
        public Vector3 linear
        {
            get;
            set;
        }

        public Vector3 angular
        {
            get;
            set;
        }

        public Accel(): base()
        {
        }

        public Accel(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            linear.Serilize(binaryWriter);
            angular.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            linear = new Vector3(binaryReader);
            angular = new Vector3(binaryReader);
        }
    }
}