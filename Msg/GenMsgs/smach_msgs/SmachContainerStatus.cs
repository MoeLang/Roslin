namespace Roslin.Msg.smach_msgs
{
    [MsgInfo("smach_msgs/SmachContainerStatus", "5ba2bb79ac19e3842d562a191f2a675b", @"Header header

# The path to this node in the server
string path

# The initial state description
# Effects an arc from the top state to each one
string[] initial_states

# The current state description
string[] active_states

# A pickled user data structure
# i.e. the UserData's internal dictionary
string local_data

# Debugging info string
string info
")]
    public partial class SmachContainerStatus : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

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

        public System.String[] active_states
        {
            get;
            set;
        }

        public System.String local_data
        {
            get;
            set;
        }

        public System.String info
        {
            get;
            set;
        }

        public SmachContainerStatus(): base()
        {
        }

        public SmachContainerStatus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(path.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( path ) ) ; 
            binaryWriter.Write(initial_states.Length); for  ( int  i  =  0 ;  i < initial_states . Length ;  i ++ ) { binaryWriter . Write ( initial_states [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( initial_states [ i ] ) ) ;  }
            binaryWriter.Write(active_states.Length); for  ( int  i  =  0 ;  i < active_states . Length ;  i ++ ) { binaryWriter . Write ( active_states [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( active_states [ i ] ) ) ;  }
            binaryWriter.Write(local_data.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( local_data ) ) ; 
            binaryWriter.Write(info.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( info ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            path = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            initial_states = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < initial_states . Length ;  i ++ ) initial_states [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            active_states = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < active_states . Length ;  i ++ ) active_states [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            local_data = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            info = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}