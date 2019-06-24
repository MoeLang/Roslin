namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SystemRptInt", "9fc8568a79d68cb7474969c688231163", @"Header header

bool enabled
bool override_active
bool command_output_fault
bool input_output_fault
bool output_reported_fault
bool pacmod_fault
bool vehicle_fault

uint16 manual_input
uint16 command
uint16 output

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
uint16 SHIFT_BETWEEN_GEARS = 5
uint16 SHIFT_ERROR = 6
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
    public partial class SystemRptInt : RosMsg
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
        public System.UInt16 SHIFT_BETWEEN_GEARS => 5;
        public System.UInt16 SHIFT_ERROR => 6;
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

        public System.Boolean enabled
        {
            get;
            set;
        }

        public System.Boolean override_active
        {
            get;
            set;
        }

        public System.Boolean command_output_fault
        {
            get;
            set;
        }

        public System.Boolean input_output_fault
        {
            get;
            set;
        }

        public System.Boolean output_reported_fault
        {
            get;
            set;
        }

        public System.Boolean pacmod_fault
        {
            get;
            set;
        }

        public System.Boolean vehicle_fault
        {
            get;
            set;
        }

        public System.UInt16 manual_input
        {
            get;
            set;
        }

        public System.UInt16 command
        {
            get;
            set;
        }

        public System.UInt16 output
        {
            get;
            set;
        }

        public SystemRptInt(): base()
        {
        }

        public SystemRptInt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(enabled);
            binaryWriter.Write(override_active);
            binaryWriter.Write(command_output_fault);
            binaryWriter.Write(input_output_fault);
            binaryWriter.Write(output_reported_fault);
            binaryWriter.Write(pacmod_fault);
            binaryWriter.Write(vehicle_fault);
            binaryWriter.Write(manual_input);
            binaryWriter.Write(command);
            binaryWriter.Write(output);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            enabled = binaryReader.ReadBoolean();
            override_active = binaryReader.ReadBoolean();
            command_output_fault = binaryReader.ReadBoolean();
            input_output_fault = binaryReader.ReadBoolean();
            output_reported_fault = binaryReader.ReadBoolean();
            pacmod_fault = binaryReader.ReadBoolean();
            vehicle_fault = binaryReader.ReadBoolean();
            manual_input = binaryReader.ReadUInt16();
            command = binaryReader.ReadUInt16();
            output = binaryReader.ReadUInt16();
        }
    }
}