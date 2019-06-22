namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/UserInputADAS", "7e781a180633792b238750d67dd1490f", "# User input (e.g. button presses) related to the factory ADAS functions\nHeader header\n\nbool btn_cc_on          # Cruise Control on\nbool btn_cc_off         # Cruise Control off\nbool btn_cc_on_off      # Cruise Control on/off toggle\nbool btn_cc_set_inc     # Cruise Control set/speed +\nbool btn_cc_set_dec     # Cruise Control set/speed -\nbool btn_cc_res         # Cruise Control resume\nbool btn_cc_cncl        # Cruise Control cancel\nbool btn_cc_res_cncl    # Cruise Control resume/cancle toggle\nbool btn_acc_gap_inc    # Adaptive Cruise Control gap -\nbool btn_acc_gap_dec    # Adaptive Cruise Control gap +\nbool btn_lka_on         # Lane Keep Assist off\nbool btn_lka_off        # Lane Keep Assist on\nbool btn_lka_on_off     # Lane Keep Assist on/off toggle\n")]
    public partial class UserInputADAS : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean btn_cc_on
        {
            get;
            set;
        }

        public System.Boolean btn_cc_off
        {
            get;
            set;
        }

        public System.Boolean btn_cc_on_off
        {
            get;
            set;
        }

        public System.Boolean btn_cc_set_inc
        {
            get;
            set;
        }

        public System.Boolean btn_cc_set_dec
        {
            get;
            set;
        }

        public System.Boolean btn_cc_res
        {
            get;
            set;
        }

        public System.Boolean btn_cc_cncl
        {
            get;
            set;
        }

        public System.Boolean btn_cc_res_cncl
        {
            get;
            set;
        }

        public System.Boolean btn_acc_gap_inc
        {
            get;
            set;
        }

        public System.Boolean btn_acc_gap_dec
        {
            get;
            set;
        }

        public System.Boolean btn_lka_on
        {
            get;
            set;
        }

        public System.Boolean btn_lka_off
        {
            get;
            set;
        }

        public System.Boolean btn_lka_on_off
        {
            get;
            set;
        }

        public UserInputADAS(): base()
        {
        }

        public UserInputADAS(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(btn_cc_on);
            binaryWriter.Write(btn_cc_off);
            binaryWriter.Write(btn_cc_on_off);
            binaryWriter.Write(btn_cc_set_inc);
            binaryWriter.Write(btn_cc_set_dec);
            binaryWriter.Write(btn_cc_res);
            binaryWriter.Write(btn_cc_cncl);
            binaryWriter.Write(btn_cc_res_cncl);
            binaryWriter.Write(btn_acc_gap_inc);
            binaryWriter.Write(btn_acc_gap_dec);
            binaryWriter.Write(btn_lka_on);
            binaryWriter.Write(btn_lka_off);
            binaryWriter.Write(btn_lka_on_off);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            btn_cc_on = binaryReader.ReadBoolean();
            btn_cc_off = binaryReader.ReadBoolean();
            btn_cc_on_off = binaryReader.ReadBoolean();
            btn_cc_set_inc = binaryReader.ReadBoolean();
            btn_cc_set_dec = binaryReader.ReadBoolean();
            btn_cc_res = binaryReader.ReadBoolean();
            btn_cc_cncl = binaryReader.ReadBoolean();
            btn_cc_res_cncl = binaryReader.ReadBoolean();
            btn_acc_gap_inc = binaryReader.ReadBoolean();
            btn_acc_gap_dec = binaryReader.ReadBoolean();
            btn_lka_on = binaryReader.ReadBoolean();
            btn_lka_off = binaryReader.ReadBoolean();
            btn_lka_on_off = binaryReader.ReadBoolean();
        }
    }
}