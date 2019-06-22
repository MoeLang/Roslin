namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/JointState", "3066dcd76a6cfaef579bd0f34173e9fd", "# This is a message that holds data to describe the state of a set of torque controlled joints. \n#\n# The state of each joint (revolute or prismatic) is defined by:\n#  * the position of the joint (rad or m),\n#  * the velocity of the joint (rad/s or m/s) and \n#  * the effort that is applied in the joint (Nm or N).\n#\n# Each joint is uniquely identified by its name\n# The header specifies the time at which the joint states were recorded. All the joint states\n# in one message have to be recorded at the same time.\n#\n# This message consists of a multiple arrays, one for each part of the joint state. \n# The goal is to make each of the fields optional. When e.g. your joints have no\n# effort associated with them, you can leave the effort array empty. \n#\n# All arrays in this message should have the same size, or be empty.\n# This is the only way to uniquely associate the joint name with the correct\n# states.\n\n\nHeader header\n\nstring[] name\nfloat64[] position\nfloat64[] velocity\nfloat64[] effort\n")]
    public partial class JointState : RosMsg
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

        public System.Double[] position
        {
            get;
            set;
        }

        public System.Double[] velocity
        {
            get;
            set;
        }

        public System.Double[] effort
        {
            get;
            set;
        }

        public JointState(): base()
        {
        }

        public JointState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(name.Length); for  ( int  i  =  0 ;  i < name . Length ;  i ++ ) { binaryWriter . Write ( name [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name [ i ] ) ) ;  }
            binaryWriter.Write(position.Length); for  ( int  i  =  0 ;  i < position . Length ;  i ++ ) binaryWriter . Write ( position [ i ] ) ; 
            binaryWriter.Write(velocity.Length); for  ( int  i  =  0 ;  i < velocity . Length ;  i ++ ) binaryWriter . Write ( velocity [ i ] ) ; 
            binaryWriter.Write(effort.Length); for  ( int  i  =  0 ;  i < effort . Length ;  i ++ ) binaryWriter . Write ( effort [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            name = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < name . Length ;  i ++ ) name [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            position = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < position . Length ;  i ++ ) position [ i ]  =  binaryReader . ReadDouble ( ) ; 
            velocity = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < velocity . Length ;  i ++ ) velocity [ i ]  =  binaryReader . ReadDouble ( ) ; 
            effort = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < effort . Length ;  i ++ ) effort [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}