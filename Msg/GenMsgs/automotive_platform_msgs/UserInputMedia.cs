namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/UserInputMedia", "cc8e2078d79a82d9d486b8f55a126c7f", @"# User input (e.g. button presses) related to media controls
Header header

bool btn_vol_up
bool btn_vol_down
bool btn_mute
bool btn_next
bool btn_prev
bool btn_next_hang_up
bool btn_prev_answer
bool btn_hang_up
bool btn_answer
bool btn_play
bool btn_pause
bool btn_play_pause
bool btn_mode
")]
    public partial class UserInputMedia : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean btn_vol_up
        {
            get;
            set;
        }

        public System.Boolean btn_vol_down
        {
            get;
            set;
        }

        public System.Boolean btn_mute
        {
            get;
            set;
        }

        public System.Boolean btn_next
        {
            get;
            set;
        }

        public System.Boolean btn_prev
        {
            get;
            set;
        }

        public System.Boolean btn_next_hang_up
        {
            get;
            set;
        }

        public System.Boolean btn_prev_answer
        {
            get;
            set;
        }

        public System.Boolean btn_hang_up
        {
            get;
            set;
        }

        public System.Boolean btn_answer
        {
            get;
            set;
        }

        public System.Boolean btn_play
        {
            get;
            set;
        }

        public System.Boolean btn_pause
        {
            get;
            set;
        }

        public System.Boolean btn_play_pause
        {
            get;
            set;
        }

        public System.Boolean btn_mode
        {
            get;
            set;
        }

        public UserInputMedia(): base()
        {
        }

        public UserInputMedia(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(btn_vol_up);
            binaryWriter.Write(btn_vol_down);
            binaryWriter.Write(btn_mute);
            binaryWriter.Write(btn_next);
            binaryWriter.Write(btn_prev);
            binaryWriter.Write(btn_next_hang_up);
            binaryWriter.Write(btn_prev_answer);
            binaryWriter.Write(btn_hang_up);
            binaryWriter.Write(btn_answer);
            binaryWriter.Write(btn_play);
            binaryWriter.Write(btn_pause);
            binaryWriter.Write(btn_play_pause);
            binaryWriter.Write(btn_mode);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            btn_vol_up = binaryReader.ReadBoolean();
            btn_vol_down = binaryReader.ReadBoolean();
            btn_mute = binaryReader.ReadBoolean();
            btn_next = binaryReader.ReadBoolean();
            btn_prev = binaryReader.ReadBoolean();
            btn_next_hang_up = binaryReader.ReadBoolean();
            btn_prev_answer = binaryReader.ReadBoolean();
            btn_hang_up = binaryReader.ReadBoolean();
            btn_answer = binaryReader.ReadBoolean();
            btn_play = binaryReader.ReadBoolean();
            btn_pause = binaryReader.ReadBoolean();
            btn_play_pause = binaryReader.ReadBoolean();
            btn_mode = binaryReader.ReadBoolean();
        }
    }
}