namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/ComponentRpt", "1d5b5cb01195437dc5e2f534206c1017", @"Header header

uint8 component_type
uint8 component_func
uint8 counter
uint8 complement

bool config_fault

uint8 COMPONENT_TYPE_PACMOD = 0
uint8 COMPONENT_TYPE_PACMINI = 1
uint8 COMPONENT_TYPE_PACMICRO = 2

uint8 COMPONENT_FUNC_PACMOD = 0
uint8 COMPONENT_FUNC_STEERING_AND_STEERING_COLUMN = 1
uint8 COMPONENT_FUNC_ACCELERATOR_AND_BRAKING = 2
uint8 COMPONENT_FUNC_BRAKING = 3
uint8 COMPONENT_FUNC_SHIFTING = 4
uint8 COMPONENT_FUNC_STEERING = 5
uint8 COMPONENT_FUNC_E_SHIFTER = 6
uint8 COMPONENT_FUNC_WATCHDOG = 7
")]
    public partial class ComponentRpt : RosMsg
    {
        public System.Byte COMPONENT_TYPE_PACMOD => 0;
        public System.Byte COMPONENT_TYPE_PACMINI => 1;
        public System.Byte COMPONENT_TYPE_PACMICRO => 2;
        public System.Byte COMPONENT_FUNC_PACMOD => 0;
        public System.Byte COMPONENT_FUNC_STEERING_AND_STEERING_COLUMN => 1;
        public System.Byte COMPONENT_FUNC_ACCELERATOR_AND_BRAKING => 2;
        public System.Byte COMPONENT_FUNC_BRAKING => 3;
        public System.Byte COMPONENT_FUNC_SHIFTING => 4;
        public System.Byte COMPONENT_FUNC_STEERING => 5;
        public System.Byte COMPONENT_FUNC_E_SHIFTER => 6;
        public System.Byte COMPONENT_FUNC_WATCHDOG => 7;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Byte component_type
        {
            get;
            set;
        }

        public System.Byte component_func
        {
            get;
            set;
        }

        public System.Byte counter
        {
            get;
            set;
        }

        public System.Byte complement
        {
            get;
            set;
        }

        public System.Boolean config_fault
        {
            get;
            set;
        }

        public ComponentRpt(): base()
        {
        }

        public ComponentRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(component_type);
            binaryWriter.Write(component_func);
            binaryWriter.Write(counter);
            binaryWriter.Write(complement);
            binaryWriter.Write(config_fault);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            component_type = binaryReader.ReadByte();
            component_func = binaryReader.ReadByte();
            counter = binaryReader.ReadByte();
            complement = binaryReader.ReadByte();
            config_fault = binaryReader.ReadBoolean();
        }
    }
}