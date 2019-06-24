namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/InteractiveMarker", "dd86d22909d5a3364b384492e35c10af", @"# Time/frame info.
# If header.time is set to 0, the marker will be retransformed into
# its frame on each timestep. You will receive the pose feedback
# in the same frame.
# Otherwise, you might receive feedback in a different frame.
# For rviz, this will be the current 'fixed frame' set by the user.
Header header

# Initial pose. Also, defines the pivot point for rotations.
geometry_msgs/Pose pose

# Identifying string. Must be globally unique in
# the topic that this message is sent through.
string name

# Short description (< 40 characters).
string description

# Scale to be used for default controls (default=1).
float32 scale

# All menu and submenu entries associated with this marker.
MenuEntry[] menu_entries

# List of controls displayed for this marker.
InteractiveMarkerControl[] controls
")]
    public partial class InteractiveMarker : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public System.String description
        {
            get;
            set;
        }

        public System.Single scale
        {
            get;
            set;
        }

        public MenuEntry[] menu_entries
        {
            get;
            set;
        }

        public InteractiveMarkerControl[] controls
        {
            get;
            set;
        }

        public InteractiveMarker(): base()
        {
        }

        public InteractiveMarker(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            pose.Serilize(binaryWriter);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(description.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( description ) ) ; 
            binaryWriter.Write(scale);
            binaryWriter.Write(menu_entries.Length); for  ( int  i  =  0 ;  i < menu_entries . Length ;  i ++ ) menu_entries [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(controls.Length); for  ( int  i  =  0 ;  i < controls . Length ;  i ++ ) controls [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            pose = new geometry_msgs.Pose(binaryReader);
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            description = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            scale = binaryReader.ReadSingle();
            menu_entries = new MenuEntry[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < menu_entries . Length ;  i ++ ) menu_entries [ i ]  =  new  MenuEntry ( binaryReader ) ; 
            controls = new InteractiveMarkerControl[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < controls . Length ;  i ++ ) controls [ i ]  =  new  InteractiveMarkerControl ( binaryReader ) ; 
        }
    }
}