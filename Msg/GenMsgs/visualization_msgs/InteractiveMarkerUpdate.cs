namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/InteractiveMarkerUpdate", "710d308d0a9276d65945e92dd30b3946", @"# Identifying string. Must be unique in the topic namespace
# that this server works on.
string server_id

# Sequence number.
# The client will use this to detect if it has missed an update.
uint64 seq_num

# Type holds the purpose of this message.  It must be one of UPDATE or KEEP_ALIVE.
# UPDATE: Incremental update to previous state. 
#         The sequence number must be 1 higher than for
#         the previous update.
# KEEP_ALIVE: Indicates the that the server is still living.
#             The sequence number does not increase.
#             No payload data should be filled out (markers, poses, or erases).
uint8 KEEP_ALIVE = 0
uint8 UPDATE = 1

uint8 type

#Note: No guarantees on the order of processing.
#      Contents must be kept consistent by sender.

#Markers to be added or updated
InteractiveMarker[] markers

#Poses of markers that should be moved
InteractiveMarkerPose[] poses

#Names of markers to be erased
string[] erases
")]
    public partial class InteractiveMarkerUpdate : RosMsg
    {
        public System.Byte KEEP_ALIVE => 0;
        public System.Byte UPDATE => 1;
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

        public System.Byte type
        {
            get;
            set;
        }

        public InteractiveMarker[] markers
        {
            get;
            set;
        }

        public InteractiveMarkerPose[] poses
        {
            get;
            set;
        }

        public System.String[] erases
        {
            get;
            set;
        }

        public InteractiveMarkerUpdate(): base()
        {
        }

        public InteractiveMarkerUpdate(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(server_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( server_id ) ) ; 
            binaryWriter.Write(seq_num);
            binaryWriter.Write(type);
            binaryWriter.Write(markers.Length); for  ( int  i  =  0 ;  i < markers . Length ;  i ++ ) markers [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(poses.Length); for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(erases.Length); for  ( int  i  =  0 ;  i < erases . Length ;  i ++ ) { binaryWriter . Write ( erases [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( erases [ i ] ) ) ;  }
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            server_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            seq_num = binaryReader.ReadUInt64();
            type = binaryReader.ReadByte();
            markers = new InteractiveMarker[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < markers . Length ;  i ++ ) markers [ i ]  =  new  InteractiveMarker ( binaryReader ) ; 
            poses = new InteractiveMarkerPose[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ]  =  new  InteractiveMarkerPose ( binaryReader ) ; 
            erases = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < erases . Length ;  i ++ ) erases [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
        }
    }
}