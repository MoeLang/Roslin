namespace Roslin.Msg.rosgraph_msgs
{
    [MsgInfo("rosgraph_msgs/Log", "acffd30cd6b6de30f120938c17c593fb", @"##
## Severity level constants
##
byte DEBUG=1 #debug level
byte INFO=2  #general level
byte WARN=4  #warning level
byte ERROR=8 #error level
byte FATAL=16 #fatal/critical level
##
## Fields
##
Header header
byte level
string name # name of the node
string msg # message 
string file # file the message came from
string function # function the message came from
uint32 line # line the message came from
string[] topics # topic names that the node publishes
")]
    public partial class Log : RosMsg
    {
        public System.Byte DEBUG => 1;
        public System.Byte INFO => 2;
        public System.Byte WARN => 4;
        public System.Byte ERROR => 8;
        public System.Byte FATAL => 16;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Byte level
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public System.String msg
        {
            get;
            set;
        }

        public System.String file
        {
            get;
            set;
        }

        public System.String function
        {
            get;
            set;
        }

        public System.UInt32 line
        {
            get;
            set;
        }

        public System.String[] topics
        {
            get;
            set;
        }

        public Log(): base()
        {
        }

        public Log(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(level);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(msg.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( msg ) ) ; 
            binaryWriter.Write(file.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( file ) ) ; 
            binaryWriter.Write(function.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( function ) ) ; 
            binaryWriter.Write(line);
            binaryWriter.Write(topics.Length); for  ( int  i  =  0 ;  i < topics . Length ;  i ++ ) { binaryWriter . Write ( topics [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( topics [ i ] ) ) ;  }
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            level = binaryReader.ReadByte();
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            msg = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            file = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            function = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            line = binaryReader.ReadUInt32();
            topics = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < topics . Length ;  i ++ ) topics [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
        }
    }
}