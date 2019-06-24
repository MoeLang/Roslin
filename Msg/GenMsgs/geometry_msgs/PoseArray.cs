namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/PoseArray", "916c28c5764443f268b296bb671b9d97", @"# An array of poses with a header for global reference.

Header header

Pose[] poses
")]
    public partial class PoseArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Pose[] poses
        {
            get;
            set;
        }

        public PoseArray(): base()
        {
        }

        public PoseArray(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            poses = new Pose[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ]  =  new  Pose ( binaryReader ) ; 
        }
    }
}