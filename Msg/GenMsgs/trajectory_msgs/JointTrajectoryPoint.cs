namespace Roslin.Msg.trajectory_msgs
{
    [MsgInfo("trajectory_msgs/JointTrajectoryPoint", "f3cd1e1c4d320c79d6985c904ae5dcd3", "# Each trajectory point specifies either positions[, velocities[, accelerations]]\n# or positions[, effort] for the trajectory to be executed.\n# All specified values are in the same order as the joint names in JointTrajectory.msg\n\nfloat64[] positions\nfloat64[] velocities\nfloat64[] accelerations\nfloat64[] effort\nduration time_from_start\n")]
    public partial class JointTrajectoryPoint : RosMsg
    {
        public System.Double[] positions
        {
            get;
            set;
        }

        public System.Double[] velocities
        {
            get;
            set;
        }

        public System.Double[] accelerations
        {
            get;
            set;
        }

        public System.Double[] effort
        {
            get;
            set;
        }

        public System.TimeSpan time_from_start
        {
            get;
            set;
        }

        public JointTrajectoryPoint(): base()
        {
        }

        public JointTrajectoryPoint(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(positions.Length); for  ( int  i  =  0 ;  i < positions . Length ;  i ++ ) binaryWriter . Write ( positions [ i ] ) ; 
            binaryWriter.Write(velocities.Length); for  ( int  i  =  0 ;  i < velocities . Length ;  i ++ ) binaryWriter . Write ( velocities [ i ] ) ; 
            binaryWriter.Write(accelerations.Length); for  ( int  i  =  0 ;  i < accelerations . Length ;  i ++ ) binaryWriter . Write ( accelerations [ i ] ) ; 
            binaryWriter.Write(effort.Length); for  ( int  i  =  0 ;  i < effort . Length ;  i ++ ) binaryWriter . Write ( effort [ i ] ) ; 
            binaryWriter.Write(time_from_start);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            positions = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < positions . Length ;  i ++ ) positions [ i ]  =  binaryReader . ReadDouble ( ) ; 
            velocities = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < velocities . Length ;  i ++ ) velocities [ i ]  =  binaryReader . ReadDouble ( ) ; 
            accelerations = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < accelerations . Length ;  i ++ ) accelerations [ i ]  =  binaryReader . ReadDouble ( ) ; 
            effort = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < effort . Length ;  i ++ ) effort [ i ]  =  binaryReader . ReadDouble ( ) ; 
            time_from_start = binaryReader.ReadTimeSpan();
        }
    }
}