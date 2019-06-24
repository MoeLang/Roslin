namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/MenuEntry", "b90ec63024573de83b57aa93eb39be2d", @"# MenuEntry message.

# Each InteractiveMarker message has an array of MenuEntry messages.
# A collection of MenuEntries together describe a
# menu/submenu/subsubmenu/etc tree, though they are stored in a flat
# array.  The tree structure is represented by giving each menu entry
# an ID number and a ""parent_id"" field.  Top-level entries are the
# ones with parent_id = 0.  Menu entries are ordered within their
# level the same way they are ordered in the containing array.  Parent
# entries must appear before their children.

# Example:
# - id = 3
#   parent_id = 0
#   title = ""fun""
# - id = 2
#   parent_id = 0
#   title = ""robot""
# - id = 4
#   parent_id = 2
#   title = ""pr2""
# - id = 5
#   parent_id = 2
#   title = ""turtle""
#
# Gives a menu tree like this:
#  - fun
#  - robot
#    - pr2
#    - turtle

# ID is a number for each menu entry.  Must be unique within the
# control, and should never be 0.
uint32 id

# ID of the parent of this menu entry, if it is a submenu.  If this
# menu entry is a top-level entry, set parent_id to 0.
uint32 parent_id

# menu / entry title
string title

# Arguments to command indicated by command_type (below)
string command

# Command_type stores the type of response desired when this menu
# entry is clicked.
# FEEDBACK: send an InteractiveMarkerFeedback message with menu_entry_id set to this entry's id.
# ROSRUN: execute ""rosrun"" with arguments given in the command field (above).
# ROSLAUNCH: execute ""roslaunch"" with arguments given in the command field (above).
uint8 FEEDBACK=0
uint8 ROSRUN=1
uint8 ROSLAUNCH=2
uint8 command_type
")]
    public partial class MenuEntry : RosMsg
    {
        public System.Byte FEEDBACK => 0;
        public System.Byte ROSRUN => 1;
        public System.Byte ROSLAUNCH => 2;
        public System.UInt32 id
        {
            get;
            set;
        }

        public System.UInt32 parent_id
        {
            get;
            set;
        }

        public System.String title
        {
            get;
            set;
        }

        public System.String command
        {
            get;
            set;
        }

        public System.Byte command_type
        {
            get;
            set;
        }

        public MenuEntry(): base()
        {
        }

        public MenuEntry(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(id);
            binaryWriter.Write(parent_id);
            binaryWriter.Write(title.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( title ) ) ; 
            binaryWriter.Write(command.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( command ) ) ; 
            binaryWriter.Write(command_type);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            id = binaryReader.ReadUInt32();
            parent_id = binaryReader.ReadUInt32();
            title = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            command = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            command_type = binaryReader.ReadByte();
        }
    }
}