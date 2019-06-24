namespace Roslin.Msg.nav_msgs
{
    [MsgInfo("nav_msgs/Path", "6227e2b7e9cce15051f669a5e197bbf7", @"#An array of poses that represents a Path for a robot to follow
Header header
geometry_msgs/PoseStamped[] poses
")]
    public partial class Path : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.PoseStamped[] poses
        {
            get;
            set;
        }

        public Path(): base()
        {
        }

        public Path(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(poses.Length); for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            poses = new geometry_msgs.PoseStamped[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ]  =  new  geometry_msgs . PoseStamped ( binaryReader ) ; 
        }
    }
}