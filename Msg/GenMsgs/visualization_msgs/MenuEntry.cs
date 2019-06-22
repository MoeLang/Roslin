namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/MenuEntry", "b90ec63024573de83b57aa93eb39be2d", "# MenuEntry message.\n\n# Each InteractiveMarker message has an array of MenuEntry messages.\n# A collection of MenuEntries together describe a\n# menu/submenu/subsubmenu/etc tree, though they are stored in a flat\n# array.  The tree structure is represented by giving each menu entry\n# an ID number and a \"parent_id\" field.  Top-level entries are the\n# ones with parent_id = 0.  Menu entries are ordered within their\n# level the same way they are ordered in the containing array.  Parent\n# entries must appear before their children.\n\n# Example:\n# - id = 3\n#   parent_id = 0\n#   title = \"fun\"\n# - id = 2\n#   parent_id = 0\n#   title = \"robot\"\n# - id = 4\n#   parent_id = 2\n#   title = \"pr2\"\n# - id = 5\n#   parent_id = 2\n#   title = \"turtle\"\n#\n# Gives a menu tree like this:\n#  - fun\n#  - robot\n#    - pr2\n#    - turtle\n\n# ID is a number for each menu entry.  Must be unique within the\n# control, and should never be 0.\nuint32 id\n\n# ID of the parent of this menu entry, if it is a submenu.  If this\n# menu entry is a top-level entry, set parent_id to 0.\nuint32 parent_id\n\n# menu / entry title\nstring title\n\n# Arguments to command indicated by command_type (below)\nstring command\n\n# Command_type stores the type of response desired when this menu\n# entry is clicked.\n# FEEDBACK: send an InteractiveMarkerFeedback message with menu_entry_id set to this entry's id.\n# ROSRUN: execute \"rosrun\" with arguments given in the command field (above).\n# ROSLAUNCH: execute \"roslaunch\" with arguments given in the command field (above).\nuint8 FEEDBACK=0\nuint8 ROSRUN=1\nuint8 ROSLAUNCH=2\nuint8 command_type\n")]
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