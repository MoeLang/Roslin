namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/WorldState", "de1a9de3ab7ba97ac0e9ec01a4eb481e", @"# This is a message that holds data necessary to reconstruct a snapshot of the world
#
# = Approach to Message Passing =
# The state of the world is defined by either
#   1. Inertial Model pose, twist
#      * kinematic data - connectivity graph from Model to each Link
#      * joint angles
#      * joint velocities
#      * Applied forces - Body wrench
#        * relative transform from Body to each collision Geom
# Or
#   2. Inertial (absolute) Body pose, twist, wrench
#      * relative transform from Body to each collision Geom - constant, so not sent over wire
#      * back compute from canonical body info to get Model pose and twist.
#
# Chooing (2.) because it matches most physics engines out there
#   and is simpler.
#
# = Future =
# Consider impacts on using reduced coordinates / graph (parent/child links) approach
#   constraint and physics solvers.
#
# = Application =
# This message is used to do the following:
#   * reconstruct the world and objects for sensor generation
#   * stop / start simulation - need pose, twist, wrench of each body
#   * collision detection - need pose of each collision geometry.  velocity/acceleration if
#
# = Assumptions =
# Assuming that each (physics) processor node locally already has
#   * collision information - Trimesh for Geoms, etc
#   * relative transforms from Body to Geom - this is assumed to be fixed, do not send oved wire
#   * inertial information - does not vary in time
#   * visual information - does not vary in time
#

Header header

string[] name
geometry_msgs/Pose[] pose
geometry_msgs/Twist[] twist
geometry_msgs/Wrench[] wrench
")]
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