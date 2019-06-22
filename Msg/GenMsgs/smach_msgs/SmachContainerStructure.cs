namespace Roslin.Msg.smach_msgs
{
    [MsgInfo("smach_msgs/SmachContainerStructure", "3d3d1e0d0f99779ee9e58101a5dcf7ea", "Header header\n\n# The path to this node in the server\nstring path\n\n# The children of this node\nstring[] children\n\n# The outcome edges\n# Each index across these arrays denote one edge\nstring[] internal_outcomes\nstring[] outcomes_from\nstring[] outcomes_to\n\n# The potential outcomes from this container\nstring[] container_outcomes\n")]
    public partial class SmachContainerStructure : RosMsg
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

        public System.String[] children
        {
            get;
            set;
        }

        public System.String[] internal_outcomes
        {
            get;
            set;
        }

        public System.String[] outcomes_from
        {
            get;
            set;
        }

        public System.String[] outcomes_to
        {
            get;
            set;
        }

        public System.String[] container_outcomes
        {
            get;
            set;
        }

        public SmachContainerStructure(): base()
        {
        }

        public SmachContainerStructure(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(path.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( path ) ) ; 
            binaryWriter.Write(children.Length); for  ( int  i  =  0 ;  i < children . Length ;  i ++ ) { binaryWriter . Write ( children [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( children [ i ] ) ) ;  }
            binaryWriter.Write(internal_outcomes.Length); for  ( int  i  =  0 ;  i < internal_outcomes . Length ;  i ++ ) { binaryWriter . Write ( internal_outcomes [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( internal_outcomes [ i ] ) ) ;  }
            binaryWriter.Write(outcomes_from.Length); for  ( int  i  =  0 ;  i < outcomes_from . Length ;  i ++ ) { binaryWriter . Write ( outcomes_from [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( outcomes_from [ i ] ) ) ;  }
            binaryWriter.Write(outcomes_to.Length); for  ( int  i  =  0 ;  i < outcomes_to . Length ;  i ++ ) { binaryWriter . Write ( outcomes_to [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( outcomes_to [ i ] ) ) ;  }
            binaryWriter.Write(container_outcomes.Length); for  ( int  i  =  0 ;  i < container_outcomes . Length ;  i ++ ) { binaryWriter . Write ( container_outcomes [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( container_outcomes [ i ] ) ) ;  }
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            path = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            children = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < children . Length ;  i ++ ) children [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            internal_outcomes = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < internal_outcomes . Length ;  i ++ ) internal_outcomes [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            outcomes_from = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < outcomes_from . Length ;  i ++ ) outcomes_from [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            outcomes_to = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < outcomes_to . Length ;  i ++ ) outcomes_to [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            container_outcomes = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < container_outcomes . Length ;  i ++ ) container_outcomes [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
        }
    }
}