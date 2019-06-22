namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/ShiftAuxRpt", "c389a0ae75f88ff27518bbc4dcdfb56a", "Header header\n\nbool between_gears\nbool between_gears_is_valid\nbool stay_in_neutral_mode\nbool stay_in_neutral_mode_is_valid\nbool brake_interlock_active\nbool brake_interlock_active_is_valid\nbool speed_interlock_active\nbool speed_interlock_active_is_valid\n")]
    public partial class ShiftAuxRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean between_gears
        {
            get;
            set;
        }

        public System.Boolean between_gears_is_valid
        {
            get;
            set;
        }

        public System.Boolean stay_in_neutral_mode
        {
            get;
            set;
        }

        public System.Boolean stay_in_neutral_mode_is_valid
        {
            get;
            set;
        }

        public System.Boolean brake_interlock_active
        {
            get;
            set;
        }

        public System.Boolean brake_interlock_active_is_valid
        {
            get;
            set;
        }

        public System.Boolean speed_interlock_active
        {
            get;
            set;
        }

        public System.Boolean speed_interlock_active_is_valid
        {
            get;
            set;
        }

        public ShiftAuxRpt(): base()
        {
        }

        public ShiftAuxRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(between_gears);
            binaryWriter.Write(between_gears_is_valid);
            binaryWriter.Write(stay_in_neutral_mode);
            binaryWriter.Write(stay_in_neutral_mode_is_valid);
            binaryWriter.Write(brake_interlock_active);
            binaryWriter.Write(brake_interlock_active_is_valid);
            binaryWriter.Write(speed_interlock_active);
            binaryWriter.Write(speed_interlock_active_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            between_gears = binaryReader.ReadBoolean();
            between_gears_is_valid = binaryReader.ReadBoolean();
            stay_in_neutral_mode = binaryReader.ReadBoolean();
            stay_in_neutral_mode_is_valid = binaryReader.ReadBoolean();
            brake_interlock_active = binaryReader.ReadBoolean();
            brake_interlock_active_is_valid = binaryReader.ReadBoolean();
            speed_interlock_active = binaryReader.ReadBoolean();
            speed_interlock_active_is_valid = binaryReader.ReadBoolean();
        }
    }
}