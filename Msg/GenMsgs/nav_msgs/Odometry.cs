namespace Roslin.Msg.nav_msgs
{
    [MsgInfo("nav_msgs/Odometry", "cd5e73d190d741a2f92e81eda573aca7", "# This represents an estimate of a position and velocity in free space.  \n# The pose in this message should be specified in the coordinate frame given by header.frame_id.\n# The twist in this message should be specified in the coordinate frame given by the child_frame_id\nHeader header\nstring child_frame_id\ngeometry_msgs/PoseWithCovariance pose\ngeometry_msgs/TwistWithCovariance twist\n")]
    public partial class Odometry : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String child_frame_id
        {
            get;
            set;
        }

        public geometry_msgs.PoseWithCovariance pose
        {
            get;
            set;
        }

        public geometry_msgs.TwistWithCovariance twist
        {
            get;
            set;
        }

        public Odometry(): base()
        {
        }

        public Odometry(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(child_frame_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( child_frame_id ) ) ; 
            pose.Serilize(binaryWriter);
            twist.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            child_frame_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            pose = new geometry_msgs.PoseWithCovariance(binaryReader);
            twist = new geometry_msgs.TwistWithCovariance(binaryReader);
        }
    }
}