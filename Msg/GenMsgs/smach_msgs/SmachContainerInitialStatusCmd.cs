namespace Roslin.Msg.smach_msgs
{
    [MsgInfo("smach_msgs/SmachContainerInitialStatusCmd", "45f8cf31fc29b829db77f23001f788d6", "# The path to the node in the server\nstring path\n\n# The desired initial state(s)\nstring[] initial_states\n\n# Initial values for the local user data of the state machine\n# A pickled user data structure\n# i.e. the UserData's internal dictionary\nstring local_data\n")]
    public partial class SmachContainerInitialStatusCmd : RosMsg
    {
        public System.String path
        {
            get;
            set;
        }

        public System.String[] initial_states
        {
            get;
            set;
        }

        public System.String local_data
        {
            get;
            set;
        }

        public SmachContainerInitialStatusCmd(): base()
        {
        }

        public SmachContainerInitialStatusCmd(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(path.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( path ) ) ; 
            binaryWriter.Write(initial_states.Length); for  ( int  i  =  0 ;  i < initial_states . Length ;  i ++ ) { binaryWriter . Write ( initial_states [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( initial_states [ i ] ) ) ;  }
            binaryWriter.Write(local_data.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( local_data ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            path = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            initial_states = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < initial_states . Length ;  i ++ ) initial_states [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            local_data = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}