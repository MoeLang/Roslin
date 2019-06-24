namespace Roslin.Msg.diagnostic_msgs
{
    [MsgInfo("diagnostic_msgs/DiagnosticStatus", "d0ce08bc6e5ba34c7754f563a9cabaf1", @"# This message holds the status of an individual component of the robot.
# 

# Possible levels of operations
byte OK=0
byte WARN=1
byte ERROR=2
byte STALE=3

byte level # level of operation enumerated above 
string name # a description of the test/component reporting
string message # a description of the status
string hardware_id # a hardware unique string
KeyValue[] values # an array of values associated with the status

")]
    public partial class DiagnosticStatus : RosMsg
    {
        public System.Byte OK => 0;
        public System.Byte WARN => 1;
        public System.Byte ERROR => 2;
        public System.Byte STALE => 3;
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

        public System.String message
        {
            get;
            set;
        }

        public System.String hardware_id
        {
            get;
            set;
        }

        public KeyValue[] values
        {
            get;
            set;
        }

        public DiagnosticStatus(): base()
        {
        }

        public DiagnosticStatus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(level);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(message.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( message ) ) ; 
            binaryWriter.Write(hardware_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( hardware_id ) ) ; 
            binaryWriter.Write(values.Length); for  ( int  i  =  0 ;  i < values . Length ;  i ++ ) values [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            level = binaryReader.ReadByte();
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            message = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            hardware_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            values = new KeyValue[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < values . Length ;  i ++ ) values [ i ]  =  new  KeyValue ( binaryReader ) ; 
        }
    }
}