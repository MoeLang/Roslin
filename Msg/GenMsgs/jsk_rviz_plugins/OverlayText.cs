namespace Roslin.Msg.jsk_rviz_plugins
{
    [MsgInfo("jsk_rviz_plugins/OverlayText", "7efc1ed34881f913afcee6ba02aa1242", @"uint8 ADD = 0
uint8 DELETE = 1

uint8 action

int32 width
int32 height
int32 left
int32 top
std_msgs/ColorRGBA bg_color

int32 line_width
float32 text_size
string font
std_msgs/ColorRGBA fg_color

string text
")]
    public partial class OverlayText : RosMsg
    {
        public System.Byte ADD => 0;
        public System.Byte DELETE => 1;
        public System.Byte action
        {
            get;
            set;
        }

        public System.Int32 width
        {
            get;
            set;
        }

        public System.Int32 height
        {
            get;
            set;
        }

        public System.Int32 left
        {
            get;
            set;
        }

        public System.Int32 top
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA bg_color
        {
            get;
            set;
        }

        public System.Int32 line_width
        {
            get;
            set;
        }

        public System.Single text_size
        {
            get;
            set;
        }

        public System.String font
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA fg_color
        {
            get;
            set;
        }

        public System.String text
        {
            get;
            set;
        }

        public OverlayText(): base()
        {
        }

        public OverlayText(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(action);
            binaryWriter.Write(width);
            binaryWriter.Write(height);
            binaryWriter.Write(left);
            binaryWriter.Write(top);
            bg_color.Serilize(binaryWriter);
            binaryWriter.Write(line_width);
            binaryWriter.Write(text_size);
            binaryWriter.Write(font.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( font ) ) ; 
            fg_color.Serilize(binaryWriter);
            binaryWriter.Write(text.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( text ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            action = binaryReader.ReadByte();
            width = binaryReader.ReadInt32();
            height = binaryReader.ReadInt32();
            left = binaryReader.ReadInt32();
            top = binaryReader.ReadInt32();
            bg_color = new std_msgs.ColorRGBA(binaryReader);
            line_width = binaryReader.ReadInt32();
            text_size = binaryReader.ReadSingle();
            font = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            fg_color = new std_msgs.ColorRGBA(binaryReader);
            text = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}