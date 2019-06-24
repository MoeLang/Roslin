namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SystemCmdInt", "d91614b72507d4f4bb9570852b76d038", @"Header header

bool enable
bool ignore_overrides
bool clear_override
bool clear_faults

uint16 command

uint16 CRUISE_CONTROL_NONE = 0
uint16 CRUISE_CONTROL_CNCL = 1
uint16 CRUISE_CONTROL_ACC_FURTHER = 2
uint16 CRUISE_CONTROL_ACC_CLOSER = 3
uint16 CRUISE_CONTROL_SET_DEC = 4
uint16 CRUISE_CONTROL_RES_INC = 5

uint16 DASH_CONTROL_NONE = 0
uint16 DASH_CONTROL_OK = 1
uint16 DASH_CONTROL_LEFT = 2
uint16 DASH_CONTROL_RIGHT = 3
uint16 DASH_CONTROL_UP = 4
uint16 DASH_CONTROL_DOWN = 5

uint16 HEADLIGHTS_OFF = 0
uint16 HEADLIGHTS_PARKING_ONLY = 1
uint16 HEADLIGHTS_MANUAL_LOW = 2
uint16 HEADLIGHTS_MANUAL_HIGH = 3
uint16 HEADLIGHTS_AUTO_LOW = 4
uint16 HEADLIGHTS_AUTO_HIGH = 5

uint16 MEDIA_CONTROL_NONE = 0
uint16 MEDIA_CONTROL_VOICE_COMMAND = 1
uint16 MEDIA_CONTROL_MUTE = 2
uint16 MEDIA_CONTROL_PREV_TRACK_ANSWER = 3
uint16 MEDIA_CONTROL_NEXT_TRACK_HANG_UP = 4
uint16 MEDIA_CONTROL_VOL_UP = 5
uint16 MEDIA_CONTROL_VOL_DOWN = 6

uint16 SHIFT_PARK = 0
uint16 SHIFT_REVERSE = 1
uint16 SHIFT_NEUTRAL = 2
uint16 SHIFT_HIGH = 3
uint16 SHIFT_FORWARD = 3
uint16 SHIFT_LOW = 4
uint16 SHIFT_NONE = 7

uint16 TURN_RIGHT = 0
uint16 TURN_NONE = 1
uint16 TURN_LEFT = 2
uint16 TURN_HAZARDS = 3

uint16 WIPERS_OFF = 0
uint16 WIPERS_INT_1 = 1
uint16 WIPERS_INT_2 = 2
uint16 WIPERS_INT_3 = 3
uint16 WIPERS_INT_4 = 4
uint16 WIPERS_INT_5 = 5
uint16 WIPERS_INT_6 = 6
uint16 WIPERS_MEDIUM = 7
uint16 WIPERS_HIGH = 8
")]
    public partial class SystemCmdInt : RosMsg
    {
        public System.UInt16 CRUISE_CONTROL_NONE => 0;
        public System.UInt16 CRUISE_CONTROL_CNCL => 1;
        public System.UInt16 CRUISE_CONTROL_ACC_FURTHER => 2;
        public System.UInt16 CRUISE_CONTROL_ACC_CLOSER => 3;
        public System.UInt16 CRUISE_CONTROL_SET_DEC => 4;
        public System.UInt16 CRUISE_CONTROL_RES_INC => 5;
        public System.UInt16 DASH_CONTROL_NONE => 0;
        public System.UInt16 DASH_CONTROL_OK => 1;
        public System.UInt16 DASH_CONTROL_LEFT => 2;
        public System.UInt16 DASH_CONTROL_RIGHT => 3;
        public System.UInt16 DASH_CONTROL_UP => 4;
        public System.UInt16 DASH_CONTROL_DOWN => 5;
        public System.UInt16 HEADLIGHTS_OFF => 0;
        public System.UInt16 HEADLIGHTS_PARKING_ONLY => 1;
        public System.UInt16 HEADLIGHTS_MANUAL_LOW => 2;
        public System.UInt16 HEADLIGHTS_MANUAL_HIGH => 3;
        public System.UInt16 HEADLIGHTS_AUTO_LOW => 4;
        public System.UInt16 HEADLIGHTS_AUTO_HIGH => 5;
        public System.UInt16 MEDIA_CONTROL_NONE => 0;
        public System.UInt16 MEDIA_CONTROL_VOICE_COMMAND => 1;
        public System.UInt16 MEDIA_CONTROL_MUTE => 2;
        public System.UInt16 MEDIA_CONTROL_PREV_TRACK_ANSWER => 3;
        public System.UInt16 MEDIA_CONTROL_NEXT_TRACK_HANG_UP => 4;
        public System.UInt16 MEDIA_CONTROL_VOL_UP => 5;
        public System.UInt16 MEDIA_CONTROL_VOL_DOWN => 6;
        public System.UInt16 SHIFT_PARK => 0;
        public System.UInt16 SHIFT_REVERSE => 1;
        public System.UInt16 SHIFT_NEUTRAL => 2;
        public System.UInt16 SHIFT_HIGH => 3;
        public System.UInt16 SHIFT_FORWARD => 3;
        public System.UInt16 SHIFT_LOW => 4;
        public System.UInt16 SHIFT_NONE => 7;
        public System.UInt16 TURN_RIGHT => 0;
        public System.UInt16 TURN_NONE => 1;
        public System.UInt16 TURN_LEFT => 2;
        public System.UInt16 TURN_HAZARDS => 3;
        public System.UInt16 WIPERS_OFF => 0;
        public System.UInt16 WIPERS_INT_1 => 1;
        public System.UInt16 WIPERS_INT_2 => 2;
        public System.UInt16 WIPERS_INT_3 => 3;
        public System.UInt16 WIPERS_INT_4 => 4;
        public System.UInt16 WIPERS_INT_5 => 5;
        public System.UInt16 WIPERS_INT_6 => 6;
        public System.UInt16 WIPERS_MEDIUM => 7;
        public System.UInt16 WIPERS_HIGH => 8;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean enable
        {
            get;
            set;
        }

        public System.Boolean ignore_overrides
        {
            get;
            set;
        }

        public System.Boolean clear_override
        {
            get;
            set;
        }

        public System.Boolean clear_faults
        {
            get;
            set;
        }

        public System.UInt16 command
        {
            get;
            set;
        }

        public SystemCmdInt(): base()
        {
        }

        public SystemCmdInt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(enable);
            binaryWriter.Write(ignore_overrides);
            binaryWriter.Write(clear_override);
            binaryWriter.Write(clear_faults);
            binaryWriter.Write(command);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            enable = binaryReader.ReadBoolean();
            ignore_overrides = binaryReader.ReadBoolean();
            clear_override = binaryReader.ReadBoolean();
            clear_faults = binaryReader.ReadBoolean();
            command = binaryReader.ReadUInt16();
        }
    }
}