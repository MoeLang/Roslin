namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/InteractiveMarkerUpdate", "710d308d0a9276d65945e92dd30b3946", "# Identifying string. Must be unique in the topic namespace\n# that this server works on.\nstring server_id\n\n# Sequence number.\n# The client will use this to detect if it has missed an update.\nuint64 seq_num\n\n# Type holds the purpose of this message.  It must be one of UPDATE or KEEP_ALIVE.\n# UPDATE: Incremental update to previous state. \n#         The sequence number must be 1 higher than for\n#         the previous update.\n# KEEP_ALIVE: Indicates the that the server is still living.\n#             The sequence number does not increase.\n#             No payload data should be filled out (markers, poses, or erases).\nuint8 KEEP_ALIVE = 0\nuint8 UPDATE = 1\n\nuint8 type\n\n#Note: No guarantees on the order of processing.\n#      Contents must be kept consistent by sender.\n\n#Markers to be added or updated\nInteractiveMarker[] markers\n\n#Poses of markers that should be moved\nInteractiveMarkerPose[] poses\n\n#Names of markers to be erased\nstring[] erases\n")]
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