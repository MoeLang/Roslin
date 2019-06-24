namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/InteractiveMarkerInit", "d5f2c5045a72456d228676ab91048734", @"# Identifying string. Must be unique in the topic namespace
# that this server works on.
string server_id

# Sequence number.
# The client will use this to detect if it has missed a subsequent
# update.  Every update message will have the same sequence number as
# an init message.  Clients will likely want to unsubscribe from the
# init topic after a successful initialization to avoid receiving
# duplicate data.
uint64 seq_num

# All markers.
InteractiveMarker[] markers
")]
    public partial class InteractiveMarkerInit : RosMsg
    {
        public System.String server_id
        {
            get;
            set;
        }

        public System.UInt64 seq_num
        {
            get;
            set;
        }

        public InteractiveMarker[] markers
        {
            get;
            set;
        }

        public InteractiveMarkerInit(): base()
        {
        }

        public InteractiveMarkerInit(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(server_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( server_id ) ) ; 
            binaryWriter.Write(seq_num);
            binaryWriter.Write(markers.Length); for  ( int  i  =  0 ;  i < markers . Length ;  i ++ ) markers [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            server_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            seq_num = binaryReader.ReadUInt64();
            markers = new InteractiveMarker[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < markers . Length ;  i ++ ) markers [ i ]  =  new  InteractiveMarker ( binaryReader ) ; 
        }
    }
}