namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/InteractiveMarkerControl", "b3c81e785788195d1840b86c28da1aac", @"# Represents a control that is to be displayed together with an interactive marker

# Identifying string for this control.
# You need to assign a unique value to this to receive feedback from the GUI
# on what actions the user performs on this control (e.g. a button click).
string name


# Defines the local coordinate frame (relative to the pose of the parent
# interactive marker) in which is being rotated and translated.
# Default: Identity
geometry_msgs/Quaternion orientation


# Orientation mode: controls how orientation changes.
# INHERIT: Follow orientation of interactive marker
# FIXED: Keep orientation fixed at initial state
# VIEW_FACING: Align y-z plane with screen (x: forward, y:left, z:up).
uint8 INHERIT = 0 
uint8 FIXED = 1
uint8 VIEW_FACING = 2

uint8 orientation_mode

# Interaction mode for this control
# 
# NONE: This control is only meant for visualization; no context menu.
# MENU: Like NONE, but right-click menu is active.
# BUTTON: Element can be left-clicked.
# MOVE_AXIS: Translate along local x-axis.
# MOVE_PLANE: Translate in local y-z plane.
# ROTATE_AXIS: Rotate around local x-axis.
# MOVE_ROTATE: Combines MOVE_PLANE and ROTATE_AXIS.
uint8 NONE = 0 
uint8 MENU = 1
uint8 BUTTON = 2
uint8 MOVE_AXIS = 3 
uint8 MOVE_PLANE = 4
uint8 ROTATE_AXIS = 5
uint8 MOVE_ROTATE = 6
# ""3D"" interaction modes work with the mouse+SHIFT+CTRL or with 3D cursors.
# MOVE_3D: Translate freely in 3D space.
# ROTATE_3D: Rotate freely in 3D space about the origin of parent frame.
# MOVE_ROTATE_3D: Full 6-DOF freedom of translation and rotation about the cursor origin.
uint8 MOVE_3D = 7
uint8 ROTATE_3D = 8
uint8 MOVE_ROTATE_3D = 9

uint8 interaction_mode


# If true, the contained markers will also be visible
# when the gui is not in interactive mode.
bool always_visible


# Markers to be displayed as custom visual representation.
# Leave this empty to use the default control handles.
#
# Note: 
# - The markers can be defined in an arbitrary coordinate frame,
#   but will be transformed into the local frame of the interactive marker.
# - If the header of a marker is empty, its pose will be interpreted as 
#   relative to the pose of the parent interactive marker.
Marker[] markers


# In VIEW_FACING mode, set this to true if you don't want the markers
# to be aligned with the camera view point. The markers will show up
# as in INHERIT mode.
bool independent_marker_orientation


# Short description (< 40 characters) of what this control does,
# e.g. ""Move the robot"". 
# Default: A generic description based on the interaction mode
string description
")]
    public partial class InteractiveMarkerControl : RosMsg
    {
        public System.Byte INHERIT => 0;
        public System.Byte FIXED => 1;
        public System.Byte VIEW_FACING => 2;
        public System.Byte NONE => 0;
        public System.Byte MENU => 1;
        public System.Byte BUTTON => 2;
        public System.Byte MOVE_AXIS => 3;
        public System.Byte MOVE_PLANE => 4;
        public System.Byte ROTATE_AXIS => 5;
        public System.Byte MOVE_ROTATE => 6;
        public System.Byte MOVE_3D => 7;
        public System.Byte ROTATE_3D => 8;
        public System.Byte MOVE_ROTATE_3D => 9;
        public System.String name
        {
            get;
            set;
        }

        public geometry_msgs.Quaternion orientation
        {
            get;
            set;
        }

        public System.Byte orientation_mode
        {
            get;
            set;
        }

        public System.Byte interaction_mode
        {
            get;
            set;
        }

        public System.Boolean always_visible
        {
            get;
            set;
        }

        public Marker[] markers
        {
            get;
            set;
        }

        public System.Boolean independent_marker_orientation
        {
            get;
            set;
        }

        public System.String description
        {
            get;
            set;
        }

        public InteractiveMarkerControl(): base()
        {
        }

        public InteractiveMarkerControl(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            orientation.Serilize(binaryWriter);
            binaryWriter.Write(orientation_mode);
            binaryWriter.Write(interaction_mode);
            binaryWriter.Write(always_visible);
            binaryWriter.Write(markers.Length); for  ( int  i  =  0 ;  i < markers . Length ;  i ++ ) markers [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(independent_marker_orientation);
            binaryWriter.Write(description.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( description ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            orientation = new geometry_msgs.Quaternion(binaryReader);
            orientation_mode = binaryReader.ReadByte();
            interaction_mode = binaryReader.ReadByte();
            always_visible = binaryReader.ReadBoolean();
            markers = new Marker[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < markers . Length ;  i ++ ) markers [ i ]  =  new  Marker ( binaryReader ) ; 
            independent_marker_orientation = binaryReader.ReadBoolean();
            description = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}