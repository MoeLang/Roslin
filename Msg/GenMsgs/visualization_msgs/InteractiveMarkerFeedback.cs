namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/InteractiveMarkerFeedback", "ab0f1eee058667e28c19ff3ffc3f4b78", "# Time/frame info.\nHeader header\n\n# Identifying string. Must be unique in the topic namespace.\nstring client_id\n\n# Feedback message sent back from the GUI, e.g.\n# when the status of an interactive marker was modified by the user.\n\n# Specifies which interactive marker and control this message refers to\nstring marker_name\nstring control_name\n\n# Type of the event\n# KEEP_ALIVE: sent while dragging to keep up control of the marker\n# MENU_SELECT: a menu entry has been selected\n# BUTTON_CLICK: a button control has been clicked\n# POSE_UPDATE: the pose has been changed using one of the controls\nuint8 KEEP_ALIVE = 0\nuint8 POSE_UPDATE = 1\nuint8 MENU_SELECT = 2\nuint8 BUTTON_CLICK = 3\n\nuint8 MOUSE_DOWN = 4\nuint8 MOUSE_UP = 5\n\nuint8 event_type\n\n# Current pose of the marker\n# Note: Has to be valid for all feedback types.\ngeometry_msgs/Pose pose\n\n# Contains the ID of the selected menu entry\n# Only valid for MENU_SELECT events.\nuint32 menu_entry_id\n\n# If event_type is BUTTON_CLICK, MOUSE_DOWN, or MOUSE_UP, mouse_point\n# may contain the 3 dimensional position of the event on the\n# control.  If it does, mouse_point_valid will be true.  mouse_point\n# will be relative to the frame listed in the header.\ngeometry_msgs/Point mouse_point\nbool mouse_point_valid\n")]
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