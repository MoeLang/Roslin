namespace Roslin.Msg.trajectory_msgs
{
    [MsgInfo("trajectory_msgs/MultiDOFJointTrajectoryPoint", "3ebe08d1abd5b65862d50e09430db776", "# Each multi-dof joint can specify a transform (up to 6 DOF)\ngeometry_msgs/Transform[] transforms\n\n# There can be a velocity specified for the origin of the joint \ngeometry_msgs/Twist[] velocities\n\n# There can be an acceleration specified for the origin of the joint \ngeometry_msgs/Twist[] accelerations\n\nduration time_from_start\n")]
    public partial class MultiDOFJointTrajectoryPoint : RosMsg
    {
        public geometry_msgs.Transform[] transforms
        {
            get;
            set;
        }

        public geometry_msgs.Twist[] velocities
        {
            get;
            set;
        }

        public geometry_msgs.Twist[] accelerations
        {
            get;
            set;
        }

        public System.TimeSpan time_from_start
        {
            get;
            set;
        }

        public MultiDOFJointTrajectoryPoint(): base()
        {
        }

        public MultiDOFJointTrajectoryPoint(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(transforms.Length); for  ( int  i  =  0 ;  i < transforms . Length ;  i ++ ) transforms [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(velocities.Length); for  ( int  i  =  0 ;  i < velocities . Length ;  i ++ ) velocities [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(accelerations.Length); for  ( int  i  =  0 ;  i < accelerations . Length ;  i ++ ) accelerations [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(time_from_start);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            transforms = new geometry_msgs.Transform[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < transforms . Length ;  i ++ ) transforms [ i ]  =  new  geometry_msgs . Transform ( binaryReader ) ; 
            velocities = new geometry_msgs.Twist[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < velocities . Length ;  i ++ ) velocities [ i ]  =  new  geometry_msgs . Twist ( binaryReader ) ; 
            accelerations = new geometry_msgs.Twist[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < accelerations . Length ;  i ++ ) accelerations [ i ]  =  new  geometry_msgs . Twist ( binaryReader ) ; 
            time_from_start = binaryReader.ReadTimeSpan();
        }
    }
}