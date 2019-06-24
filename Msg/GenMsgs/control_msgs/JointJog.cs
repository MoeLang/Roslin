namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/JointJog", "1685da700c8c2e1254afc92a5fb89c96", @"# Used in time-stamping the message.
Header header

# Name list of the joints. You don't need to specify all joints of the
# robot. Joint names are case-sensitive.
string[] joint_names

# A position command to the joints listed in joint_names.
# The order must be identical.
# Units are meters or radians.
# If displacements and velocities are filled, a profiled motion is requested.
float64[] displacements # or position_deltas

# A velocity command to the joints listed in joint_names.
# The order must be identical.
# Units are m/s or rad/s.
# If displacements and velocities are filled, a profiled motion is requested.
float64[] velocities

float64 duration
")]
    public partial class JointJog : RosMsg
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

        public System.Double[] displacements
        {
            get;
            set;
        }

        public System.Double[] velocities
        {
            get;
            set;
        }

        public System.Double duration
        {
            get;
            set;
        }

        public JointJog(): base()
        {
        }

        public JointJog(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(joint_names.Length); for  ( int  i  =  0 ;  i < joint_names . Length ;  i ++ ) { binaryWriter . Write ( joint_names [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( joint_names [ i ] ) ) ;  }
            binaryWriter.Write(displacements.Length); for  ( int  i  =  0 ;  i < displacements . Length ;  i ++ ) binaryWriter . Write ( displacements [ i ] ) ; 
            binaryWriter.Write(velocities.Length); for  ( int  i  =  0 ;  i < velocities . Length ;  i ++ ) binaryWriter . Write ( velocities [ i ] ) ; 
            binaryWriter.Write(duration);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            joint_names = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < joint_names . Length ;  i ++ ) joint_names [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            displacements = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < displacements . Length ;  i ++ ) displacements [ i ]  =  binaryReader . ReadDouble ( ) ; 
            velocities = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < velocities . Length ;  i ++ ) velocities [ i ]  =  binaryReader . ReadDouble ( ) ; 
            duration = binaryReader.ReadDouble();
        }
    }
}