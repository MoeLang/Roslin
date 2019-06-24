namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/InteractiveMarkerFeedback", "ab0f1eee058667e28c19ff3ffc3f4b78", @"# Time/frame info.
Header header

# Identifying string. Must be unique in the topic namespace.
string client_id

# Feedback message sent back from the GUI, e.g.
# when the status of an interactive marker was modified by the user.

# Specifies which interactive marker and control this message refers to
string marker_name
string control_name

# Type of the event
# KEEP_ALIVE: sent while dragging to keep up control of the marker
# MENU_SELECT: a menu entry has been selected
# BUTTON_CLICK: a button control has been clicked
# POSE_UPDATE: the pose has been changed using one of the controls
uint8 KEEP_ALIVE = 0
uint8 POSE_UPDATE = 1
uint8 MENU_SELECT = 2
uint8 BUTTON_CLICK = 3

uint8 MOUSE_DOWN = 4
uint8 MOUSE_UP = 5

uint8 event_type

# Current pose of the marker
# Note: Has to be valid for all feedback types.
geometry_msgs/Pose pose

# Contains the ID of the selected menu entry
# Only valid for MENU_SELECT events.
uint32 menu_entry_id

# If event_type is BUTTON_CLICK, MOUSE_DOWN, or MOUSE_UP, mouse_point
# may contain the 3 dimensional position of the event on the
# control.  If it does, mouse_point_valid will be true.  mouse_point
# will be relative to the frame listed in the header.
geometry_msgs/Point mouse_point
bool mouse_point_valid
")]
    public partial class InteractiveMarkerFeedback : RosMsg
    {
        public System.Byte KEEP_ALIVE => 0;
        public System.Byte POSE_UPDATE => 1;
        public System.Byte MENU_SELECT => 2;
        public System.Byte BUTTON_CLICK => 3;
        public System.Byte MOUSE_DOWN => 4;
        public System.Byte MOUSE_UP => 5;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String client_id
        {
            get;
            set;
        }

        public System.String marker_name
        {
            get;
            set;
        }

        public System.String control_name
        {
            get;
            set;
        }

        public System.Byte event_type
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public System.UInt32 menu_entry_id
        {
            get;
            set;
        }

        public geometry_msgs.Point mouse_point
        {
            get;
            set;
        }

        public System.Boolean mouse_point_valid
        {
            get;
            set;
        }

        public InteractiveMarkerFeedback(): base()
        {
        }

        public InteractiveMarkerFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(client_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( client_id ) ) ; 
            binaryWriter.Write(marker_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( marker_name ) ) ; 
            binaryWriter.Write(control_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( control_name ) ) ; 
            binaryWriter.Write(event_type);
            pose.Serilize(binaryWriter);
            binaryWriter.Write(menu_entry_id);
            mouse_point.Serilize(binaryWriter);
            binaryWriter.Write(mouse_point_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            client_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            marker_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            control_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            event_type = binaryReader.ReadByte();
            pose = new geometry_msgs.Pose(binaryReader);
            menu_entry_id = binaryReader.ReadUInt32();
            mouse_point = new geometry_msgs.Point(binaryReader);
            mouse_point_valid = binaryReader.ReadBoolean();
        }
    }
}