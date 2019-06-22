namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/MultiDOFJointState", "690f272f0640d2631c305eeb8301e59d", "# Representation of state for joints with multiple degrees of freedom, \n# following the structure of JointState.\n#\n# It is assumed that a joint in a system corresponds to a transform that gets applied \n# along the kinematic chain. For example, a planar joint (as in URDF) is 3DOF (x, y, yaw)\n# and those 3DOF can be expressed as a transformation matrix, and that transformation\n# matrix can be converted back to (x, y, yaw)\n#\n# Each joint is uniquely identified by its name\n# The header specifies the time at which the joint states were recorded. All the joint states\n# in one message have to be recorded at the same time.\n#\n# This message consists of a multiple arrays, one for each part of the joint state. \n# The goal is to make each of the fields optional. When e.g. your joints have no\n# wrench associated with them, you can leave the wrench array empty. \n#\n# All arrays in this message should have the same size, or be empty.\n# This is the only way to uniquely associate the joint name with the correct\n# states.\n\nHeader header\n\nstring[] joint_names\ngeometry_msgs/Transform[] transforms\ngeometry_msgs/Twist[] twist\ngeometry_msgs/Wrench[] wrench\n")]
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