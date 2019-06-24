namespace Roslin.Msg.trajectory_msgs
{
    [MsgInfo("trajectory_msgs/MultiDOFJointTrajectory", "ef145a45a5f47b77b7f5cdde4b16c942", @"# The header is used to specify the coordinate frame and the reference time for the trajectory durations
Header header

# A representation of a multi-dof joint trajectory (each point is a transformation)
# Each point along the trajectory will include an array of positions/velocities/accelerations
# that has the same length as the array of joint names, and has the same order of joints as 
# the joint names array.

string[] joint_names
MultiDOFJointTrajectoryPoint[] points
")]
    public partial class MultiDOFJointTrajectory : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String[] joint_names
        {
            get;
            set;
        }

        public MultiDOFJointTrajectoryPoint[] points
        {
            get;
            set;
        }

        public MultiDOFJointTrajectory(): base()
        {
        }

        public MultiDOFJointTrajectory(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(joint_names.Length); for  ( int  i  =  0 ;  i < joint_names . Length ;  i ++ ) { binaryWriter . Write ( joint_names [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( joint_names [ i ] ) ) ;  }
            binaryWriter.Write(points.Length); for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            joint_names = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < joint_names . Length ;  i ++ ) joint_names [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            points = new MultiDOFJointTrajectoryPoint[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ]  =  new  MultiDOFJointTrajectoryPoint ( binaryReader ) ; 
        }
    }
}