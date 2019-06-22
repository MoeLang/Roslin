namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/AllSystemStatuses", "c02f347061ed74b0bef510eb7368d90a", "Header header\n\nKeyValuePair[] enabled_status\nKeyValuePair[] overridden_status\nKeyValuePair[] fault_status\n")]
    public partial class AllSystemStatuses : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public KeyValuePair[] enabled_status
        {
            get;
            set;
        }

        public KeyValuePair[] overridden_status
        {
            get;
            set;
        }

        public KeyValuePair[] fault_status
        {
            get;
            set;
        }

        public AllSystemStatuses(): base()
        {
        }

        public AllSystemStatuses(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(enabled_status.Length); for  ( int  i  =  0 ;  i < enabled_status . Length ;  i ++ ) enabled_status [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(overridden_status.Length); for  ( int  i  =  0 ;  i < overridden_status . Length ;  i ++ ) overridden_status [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(fault_status.Length); for  ( int  i  =  0 ;  i < fault_status . Length ;  i ++ ) fault_status [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            enabled_status = new KeyValuePair[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < enabled_status . Length ;  i ++ ) enabled_status [ i ]  =  new  KeyValuePair ( binaryReader ) ; 
            overridden_status = new KeyValuePair[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < overridden_status . Length ;  i ++ ) overridden_status [ i ]  =  new  KeyValuePair ( binaryReader ) ; 
            fault_status = new KeyValuePair[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < fault_status . Length ;  i ++ ) fault_status [ i ]  =  new  KeyValuePair ( binaryReader ) ; 
        }
    }
}