namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/InteractiveMarkerPose", "a6e6833209a196a38d798dadb02c81f8", "# Time/frame info.\nHeader header\n\n# Initial pose. Also, defines the pivot point for rotations.\ngeometry_msgs/Pose pose\n\n# Identifying string. Must be globally unique in\n# the topic that this message is sent through.\nstring name\n")]
    public partial class InteractiveMarkerPose : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public InteractiveMarkerPose(): base()
        {
        }

        public InteractiveMarkerPose(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            pose.Serilize(binaryWriter);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            pose = new geometry_msgs.Pose(binaryReader);
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}