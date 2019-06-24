namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/GlobalRpt", "e844957facaf4f6bfdea20a3ffdb048f", @"Header header

bool enabled                # Indicates whether any system on the PACMod is enabled or disabled.
bool override_active        # Indicates whether an override has been triggered on any system.
bool fault_active           # Indicates whether a fault is active on any system.
bool config_fault_active    # Indicates whether the CONFIG.TXT file was read correctly
bool user_can_timeout       # Indicates a timeout has been exceeded on the user CAN interface.
bool brake_can_timeout      # Indicates a timeout has been exceeded on the brake CAN interface.
bool steering_can_timeout   # Indicates a timeout has been exceeded on the steering CAN interface.
bool vehicle_can_timeout    # Indicates a timeout has been exceeded on a vehicle CAN interface.
bool subsystem_can_timeout  # Indicates a timeout has been exceeded when communicating with a PACMod subsystem.
bool user_can_read_errors   # The number of read errors encoutered by the PACMod on the user CAN interface.
")]
    public partial class GlobalRpt : RosMsg
    {
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

        public System.Boolean fault_active
        {
            get;
            set;
        }

        public System.Boolean config_fault_active
        {
            get;
            set;
        }

        public System.Boolean user_can_timeout
        {
            get;
            set;
        }

        public System.Boolean brake_can_timeout
        {
            get;
            set;
        }

        public System.Boolean steering_can_timeout
        {
            get;
            set;
        }

        public System.Boolean vehicle_can_timeout
        {
            get;
            set;
        }

        public System.Boolean subsystem_can_timeout
        {
            get;
            set;
        }

        public System.Boolean user_can_read_errors
        {
            get;
            set;
        }

        public GlobalRpt(): base()
        {
        }

        public GlobalRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(enabled);
            binaryWriter.Write(override_active);
            binaryWriter.Write(fault_active);
            binaryWriter.Write(config_fault_active);
            binaryWriter.Write(user_can_timeout);
            binaryWriter.Write(brake_can_timeout);
            binaryWriter.Write(steering_can_timeout);
            binaryWriter.Write(vehicle_can_timeout);
            binaryWriter.Write(subsystem_can_timeout);
            binaryWriter.Write(user_can_read_errors);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            enabled = binaryReader.ReadBoolean();
            override_active = binaryReader.ReadBoolean();
            fault_active = binaryReader.ReadBoolean();
            config_fault_active = binaryReader.ReadBoolean();
            user_can_timeout = binaryReader.ReadBoolean();
            brake_can_timeout = binaryReader.ReadBoolean();
            steering_can_timeout = binaryReader.ReadBoolean();
            vehicle_can_timeout = binaryReader.ReadBoolean();
            subsystem_can_timeout = binaryReader.ReadBoolean();
            user_can_read_errors = binaryReader.ReadBoolean();
        }
    }
}