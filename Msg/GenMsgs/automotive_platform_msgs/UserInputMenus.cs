namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/UserInputMenus", "fe6ad02b305fbde3a33fc030612b13da", @"# Inputs (e.g. button presses) for in-vehicle menus
Header header

bool str_whl_left_btn_left
bool str_whl_left_btn_down
bool str_whl_left_btn_right
bool str_whl_left_btn_up
bool str_whl_left_btn_ok

bool str_whl_right_btn_left
bool str_whl_right_btn_down
bool str_whl_right_btn_right
bool str_whl_right_btn_up
bool str_whl_right_btn_ok

bool cntr_cons_btn_left
bool cntr_cons_btn_down
bool cntr_cons_btn_right
bool cntr_cons_btn_up
bool cntr_cons_btn_ok
")]
    public partial class UserInputMenus : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean str_whl_left_btn_left
        {
            get;
            set;
        }

        public System.Boolean str_whl_left_btn_down
        {
            get;
            set;
        }

        public System.Boolean str_whl_left_btn_right
        {
            get;
            set;
        }

        public System.Boolean str_whl_left_btn_up
        {
            get;
            set;
        }

        public System.Boolean str_whl_left_btn_ok
        {
            get;
            set;
        }

        public System.Boolean str_whl_right_btn_left
        {
            get;
            set;
        }

        public System.Boolean str_whl_right_btn_down
        {
            get;
            set;
        }

        public System.Boolean str_whl_right_btn_right
        {
            get;
            set;
        }

        public System.Boolean str_whl_right_btn_up
        {
            get;
            set;
        }

        public System.Boolean str_whl_right_btn_ok
        {
            get;
            set;
        }

        public System.Boolean cntr_cons_btn_left
        {
            get;
            set;
        }

        public System.Boolean cntr_cons_btn_down
        {
            get;
            set;
        }

        public System.Boolean cntr_cons_btn_right
        {
            get;
            set;
        }

        public System.Boolean cntr_cons_btn_up
        {
            get;
            set;
        }

        public System.Boolean cntr_cons_btn_ok
        {
            get;
            set;
        }

        public UserInputMenus(): base()
        {
        }

        public UserInputMenus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(str_whl_left_btn_left);
            binaryWriter.Write(str_whl_left_btn_down);
            binaryWriter.Write(str_whl_left_btn_right);
            binaryWriter.Write(str_whl_left_btn_up);
            binaryWriter.Write(str_whl_left_btn_ok);
            binaryWriter.Write(str_whl_right_btn_left);
            binaryWriter.Write(str_whl_right_btn_down);
            binaryWriter.Write(str_whl_right_btn_right);
            binaryWriter.Write(str_whl_right_btn_up);
            binaryWriter.Write(str_whl_right_btn_ok);
            binaryWriter.Write(cntr_cons_btn_left);
            binaryWriter.Write(cntr_cons_btn_down);
            binaryWriter.Write(cntr_cons_btn_right);
            binaryWriter.Write(cntr_cons_btn_up);
            binaryWriter.Write(cntr_cons_btn_ok);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            str_whl_left_btn_left = binaryReader.ReadBoolean();
            str_whl_left_btn_down = binaryReader.ReadBoolean();
            str_whl_left_btn_right = binaryReader.ReadBoolean();
            str_whl_left_btn_up = binaryReader.ReadBoolean();
            str_whl_left_btn_ok = binaryReader.ReadBoolean();
            str_whl_right_btn_left = binaryReader.ReadBoolean();
            str_whl_right_btn_down = binaryReader.ReadBoolean();
            str_whl_right_btn_right = binaryReader.ReadBoolean();
            str_whl_right_btn_up = binaryReader.ReadBoolean();
            str_whl_right_btn_ok = binaryReader.ReadBoolean();
            cntr_cons_btn_left = binaryReader.ReadBoolean();
            cntr_cons_btn_down = binaryReader.ReadBoolean();
            cntr_cons_btn_right = binaryReader.ReadBoolean();
            cntr_cons_btn_up = binaryReader.ReadBoolean();
            cntr_cons_btn_ok = binaryReader.ReadBoolean();
        }
    }
}