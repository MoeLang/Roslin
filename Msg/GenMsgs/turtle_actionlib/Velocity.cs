namespace Roslin.Msg.turtle_actionlib
{
    [MsgInfo("turtle_actionlib/Velocity", "9d5c2dcd348ac8f76ce2a4307bd63a13", @"# Copied from turtlesim https://github.com/ros/ros_tutorials/blob/f7da7779e82dcc3977b2c220a843cd86dd269832/turtlesim/msg/Velocity.msg. We had to copy this into this package since it has been replaced with geometry_msgs/Twist there and comforming to Twist requires to change code, which I doubt worth time it takes. So if you think it is, please go ahead make a patch.

float32 linear
float32 angular
")]
    public partial class Velocity : RosMsg
    {
        public System.Single linear
        {
            get;
            set;
        }

        public System.Single angular
        {
            get;
            set;
        }

        public Velocity(): base()
        {
        }

        public Velocity(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(linear);
            binaryWriter.Write(angular);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            linear = binaryReader.ReadSingle();
            angular = binaryReader.ReadSingle();
        }
    }
}