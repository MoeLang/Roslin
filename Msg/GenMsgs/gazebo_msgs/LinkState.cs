namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/LinkState", "0818ebbf28ce3a08d48ab1eaa7309ebe", "# @todo: FIXME: sets pose and twist of a link.  All children link poses/twists of the URDF tree are not updated accordingly, but should be.\nstring link_name            # link name, link_names are in gazebo scoped name notation, [model_name::body_name]\ngeometry_msgs/Pose pose     # desired pose in reference frame\ngeometry_msgs/Twist twist   # desired twist in reference frame\nstring reference_frame      # set pose/twist relative to the frame of this link/body\n                            # leave empty or \"world\" or \"map\" defaults to world-frame\n")]
    public partial class LinkState : RosMsg
    {
        public System.String link_name
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public geometry_msgs.Twist twist
        {
            get;
            set;
        }

        public System.String reference_frame
        {
            get;
            set;
        }

        public LinkState(): base()
        {
        }

        public LinkState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(link_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( link_name ) ) ; 
            pose.Serilize(binaryWriter);
            twist.Serilize(binaryWriter);
            binaryWriter.Write(reference_frame.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( reference_frame ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            link_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            pose = new geometry_msgs.Pose(binaryReader);
            twist = new geometry_msgs.Twist(binaryReader);
            reference_frame = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}