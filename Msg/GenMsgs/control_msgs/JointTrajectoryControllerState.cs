namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/JointTrajectoryControllerState", "10817c60c2486ef6b33e97dcd87f4474", "Header header\nstring[] joint_names\ntrajectory_msgs/JointTrajectoryPoint desired\ntrajectory_msgs/JointTrajectoryPoint actual\ntrajectory_msgs/JointTrajectoryPoint error  # Redundant, but useful\n")]
    public partial class JointTrajectoryControllerState : RosMsg
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

        public trajectory_msgs.JointTrajectoryPoint desired
        {
            get;
            set;
        }

        public trajectory_msgs.JointTrajectoryPoint actual
        {
            get;
            set;
        }

        public trajectory_msgs.JointTrajectoryPoint error
        {
            get;
            set;
        }

        public JointTrajectoryControllerState(): base()
        {
        }

        public JointTrajectoryControllerState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(joint_names.Length); for  ( int  i  =  0 ;  i < joint_names . Length ;  i ++ ) { binaryWriter . Write ( joint_names [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( joint_names [ i ] ) ) ;  }
            desired.Serilize(binaryWriter);
            actual.Serilize(binaryWriter);
            error.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            joint_names = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < joint_names . Length ;  i ++ ) joint_names [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            desired = new trajectory_msgs.JointTrajectoryPoint(binaryReader);
            actual = new trajectory_msgs.JointTrajectoryPoint(binaryReader);
            error = new trajectory_msgs.JointTrajectoryPoint(binaryReader);
        }
    }
}