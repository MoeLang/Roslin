namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/MultiDOFJointState", "690f272f0640d2631c305eeb8301e59d", @"# Representation of state for joints with multiple degrees of freedom, 
# following the structure of JointState.
#
# It is assumed that a joint in a system corresponds to a transform that gets applied 
# along the kinematic chain. For example, a planar joint (as in URDF) is 3DOF (x, y, yaw)
# and those 3DOF can be expressed as a transformation matrix, and that transformation
# matrix can be converted back to (x, y, yaw)
#
# Each joint is uniquely identified by its name
# The header specifies the time at which the joint states were recorded. All the joint states
# in one message have to be recorded at the same time.
#
# This message consists of a multiple arrays, one for each part of the joint state. 
# The goal is to make each of the fields optional. When e.g. your joints have no
# wrench associated with them, you can leave the wrench array empty. 
#
# All arrays in this message should have the same size, or be empty.
# This is the only way to uniquely associate the joint name with the correct
# states.

Header header

string[] joint_names
geometry_msgs/Transform[] transforms
geometry_msgs/Twist[] twist
geometry_msgs/Wrench[] wrench
")]
    public partial class MultiDOFJointState : RosMsg
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

        public geometry_msgs.Transform[] transforms
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

        public MultiDOFJointState(): base()
        {
        }

        public MultiDOFJointState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(joint_names.Length); for  ( int  i  =  0 ;  i < joint_names . Length ;  i ++ ) { binaryWriter . Write ( joint_names [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( joint_names [ i ] ) ) ;  }
            binaryWriter.Write(transforms.Length); for  ( int  i  =  0 ;  i < transforms . Length ;  i ++ ) transforms [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(twist.Length); for  ( int  i  =  0 ;  i < twist . Length ;  i ++ ) twist [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(wrench.Length); for  ( int  i  =  0 ;  i < wrench . Length ;  i ++ ) wrench [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            joint_names = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < joint_names . Length ;  i ++ ) joint_names [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            transforms = new geometry_msgs.Transform[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < transforms . Length ;  i ++ ) transforms [ i ]  =  new  geometry_msgs . Transform ( binaryReader ) ; 
            twist = new geometry_msgs.Twist[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < twist . Length ;  i ++ ) twist [ i ]  =  new  geometry_msgs . Twist ( binaryReader ) ; 
            wrench = new geometry_msgs.Wrench[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < wrench . Length ;  i ++ ) wrench [ i ]  =  new  geometry_msgs . Wrench ( binaryReader ) ; 
        }
    }
}