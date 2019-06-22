namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/BoundingBoxMovement", "60aeb288c030d1b8a67ddeedc91812f0", "Header header\nBoundingBox box\ngeometry_msgs/Pose handle_pose\ngeometry_msgs/PoseStamped destination\n")]
    public partial class BoundingBoxMovement : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public BoundingBox box
        {
            get;
            set;
        }

        public geometry_msgs.Pose handle_pose
        {
            get;
            set;
        }

        public geometry_msgs.PoseStamped destination
        {
            get;
            set;
        }

        public BoundingBoxMovement(): base()
        {
        }

        public BoundingBoxMovement(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            box.Serilize(binaryWriter);
            handle_pose.Serilize(binaryWriter);
            destination.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            box = new BoundingBox(binaryReader);
            handle_pose = new geometry_msgs.Pose(binaryReader);
            destination = new geometry_msgs.PoseStamped(binaryReader);
        }
    }
}