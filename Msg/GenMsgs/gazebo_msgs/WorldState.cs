namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/WorldState", "de1a9de3ab7ba97ac0e9ec01a4eb481e", "# This is a message that holds data necessary to reconstruct a snapshot of the world\n#\n# = Approach to Message Passing =\n# The state of the world is defined by either\n#   1. Inertial Model pose, twist\n#      * kinematic data - connectivity graph from Model to each Link\n#      * joint angles\n#      * joint velocities\n#      * Applied forces - Body wrench\n#        * relative transform from Body to each collision Geom\n# Or\n#   2. Inertial (absolute) Body pose, twist, wrench\n#      * relative transform from Body to each collision Geom - constant, so not sent over wire\n#      * back compute from canonical body info to get Model pose and twist.\n#\n# Chooing (2.) because it matches most physics engines out there\n#   and is simpler.\n#\n# = Future =\n# Consider impacts on using reduced coordinates / graph (parent/child links) approach\n#   constraint and physics solvers.\n#\n# = Application =\n# This message is used to do the following:\n#   * reconstruct the world and objects for sensor generation\n#   * stop / start simulation - need pose, twist, wrench of each body\n#   * collision detection - need pose of each collision geometry.  velocity/acceleration if\n#\n# = Assumptions =\n# Assuming that each (physics) processor node locally already has\n#   * collision information - Trimesh for Geoms, etc\n#   * relative transforms from Body to Geom - this is assumed to be fixed, do not send oved wire\n#   * inertial information - does not vary in time\n#   * visual information - does not vary in time\n#\n\nHeader header\n\nstring[] name\ngeometry_msgs/Pose[] pose\ngeometry_msgs/Twist[] twist\ngeometry_msgs/Wrench[] wrench\n")]
    public partial class WorldState : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String[] name
        {
            get;
            set;
        }

        public geometry_msgs.Pose[] pose
        {
            get;
            set;
        }

        public geometry_msgs.Twist[] twist
        {
            get;
            set;
        }

        public geometry_msgs.Wrench[] wrench
        {
            get;
            set;
        }

        public WorldState(): base()
        {
        }

        public WorldState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(name.Length); for  ( int  i  =  0 ;  i < name . Length ;  i ++ ) { binaryWriter . Write ( name [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name [ i ] ) ) ;  }
            binaryWriter.Write(pose.Length); for  ( int  i  =  0 ;  i < pose . Length ;  i ++ ) pose [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(twist.Length); for  ( int  i  =  0 ;  i < twist . Length ;  i ++ ) twist [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(wrench.Length); for  ( int  i  =  0 ;  i < wrench . Length ;  i ++ ) wrench [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            name = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < name . Length ;  i ++ ) name [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            pose = new geometry_msgs.Pose[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < pose . Length ;  i ++ ) pose [ i ]  =  new  geometry_msgs . Pose ( binaryReader ) ; 
            twist = new geometry_msgs.Twist[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < twist . Length ;  i ++ ) twist [ i ]  =  new  geometry_msgs . Twist ( binaryReader ) ; 
            wrench = new geometry_msgs.Wrench[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < wrench . Length ;  i ++ ) wrench [ i ]  =  new  geometry_msgs . Wrench ( binaryReader ) ; 
        }
    }
}