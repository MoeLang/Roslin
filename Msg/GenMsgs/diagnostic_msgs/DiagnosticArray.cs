namespace Roslin.Msg.diagnostic_msgs
{
    [MsgInfo("diagnostic_msgs/DiagnosticArray", "60810da900de1dd6ddd437c3503511da", @"# This message is used to send diagnostic information about the state of the robot
Header header #for timestamp
DiagnosticStatus[] status # an array of components being reported on")]
    public partial class DiagnosticArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public DiagnosticStatus[] status
        {
            get;
            set;
        }

        public DiagnosticArray(): base()
        {
        }

        public DiagnosticArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(status.Length); for  ( int  i  =  0 ;  i < status . Length ;  i ++ ) status [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            status = new DiagnosticStatus[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < status . Length ;  i ++ ) status [ i ]  =  new  DiagnosticStatus ( binaryReader ) ; 
        }
    }
}