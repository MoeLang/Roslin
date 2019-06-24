namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Pose", "e45d45a5a1ce597b249e23fb30fc871f", @"# A representation of pose in free space, composed of position and orientation. 
Point position
Quaternion orientation
")]
    public partial class Pose : RosMsg
    {
        public Point position
        {
            get;
            set;
        }

        public Quaternion orientation
        {
            get;
            set;
        }

        public Pose(): base()
        {
        }

        public Pose(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            position.Serilize(binaryWriter);
            orientation.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            position = new Point(binaryReader);
            orientation = new Quaternion(binaryReader);
        }
    }
}