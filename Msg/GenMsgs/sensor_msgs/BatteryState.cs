namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/BatteryState", "476f837fa6771f6e16e3bf4ef96f8770", @"
# Constants are chosen to match the enums in the linux kernel
# defined in include/linux/power_supply.h as of version 3.7
# The one difference is for style reasons the constants are
# all uppercase not mixed case.

# Power supply status constants
uint8 POWER_SUPPLY_STATUS_UNKNOWN = 0
uint8 POWER_SUPPLY_STATUS_CHARGING = 1
uint8 POWER_SUPPLY_STATUS_DISCHARGING = 2
uint8 POWER_SUPPLY_STATUS_NOT_CHARGING = 3
uint8 POWER_SUPPLY_STATUS_FULL = 4

# Power supply health constants
uint8 POWER_SUPPLY_HEALTH_UNKNOWN = 0
uint8 POWER_SUPPLY_HEALTH_GOOD = 1
uint8 POWER_SUPPLY_HEALTH_OVERHEAT = 2
uint8 POWER_SUPPLY_HEALTH_DEAD = 3
uint8 POWER_SUPPLY_HEALTH_OVERVOLTAGE = 4
uint8 POWER_SUPPLY_HEALTH_UNSPEC_FAILURE = 5
uint8 POWER_SUPPLY_HEALTH_COLD = 6
uint8 POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE = 7
uint8 POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE = 8

# Power supply technology (chemistry) constants
uint8 POWER_SUPPLY_TECHNOLOGY_UNKNOWN = 0
uint8 POWER_SUPPLY_TECHNOLOGY_NIMH = 1
uint8 POWER_SUPPLY_TECHNOLOGY_LION = 2
uint8 POWER_SUPPLY_TECHNOLOGY_LIPO = 3
uint8 POWER_SUPPLY_TECHNOLOGY_LIFE = 4
uint8 POWER_SUPPLY_TECHNOLOGY_NICD = 5
uint8 POWER_SUPPLY_TECHNOLOGY_LIMN = 6

Header  header
float32 voltage          # Voltage in Volts (Mandatory)
float32 current          # Negative when discharging (A)  (If unmeasured NaN)
float32 charge           # Current charge in Ah  (If unmeasured NaN)
float32 capacity         # Capacity in Ah (last full capacity)  (If unmeasured NaN)
float32 design_capacity  # Capacity in Ah (design capacity)  (If unmeasured NaN)
float32 percentage       # Charge percentage on 0 to 1 range  (If unmeasured NaN)
uint8   power_supply_status     # The charging status as reported. Values defined above
uint8   power_supply_health     # The battery health metric. Values defined above
uint8   power_supply_technology # The battery chemistry. Values defined above
bool    present          # True if the battery is present

float32[] cell_voltage   # An array of individual cell voltages for each cell in the pack
                         # If individual voltages unknown but number of cells known set each to NaN
string location          # The location into which the battery is inserted. (slot number or plug)
string serial_number     # The best approximation of the battery serial number
")]
    public partial class BatteryState : RosMsg
    {
        public System.Byte POWER_SUPPLY_STATUS_UNKNOWN => 0;
        public System.Byte POWER_SUPPLY_STATUS_CHARGING => 1;
        public System.Byte POWER_SUPPLY_STATUS_DISCHARGING => 2;
        public System.Byte POWER_SUPPLY_STATUS_NOT_CHARGING => 3;
        public System.Byte POWER_SUPPLY_STATUS_FULL => 4;
        public System.Byte POWER_SUPPLY_HEALTH_UNKNOWN => 0;
        public System.Byte POWER_SUPPLY_HEALTH_GOOD => 1;
        public System.Byte POWER_SUPPLY_HEALTH_OVERHEAT => 2;
        public System.Byte POWER_SUPPLY_HEALTH_DEAD => 3;
        public System.Byte POWER_SUPPLY_HEALTH_OVERVOLTAGE => 4;
        public System.Byte POWER_SUPPLY_HEALTH_UNSPEC_FAILURE => 5;
        public System.Byte POWER_SUPPLY_HEALTH_COLD => 6;
        public System.Byte POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE => 7;
        public System.Byte POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE => 8;
        public System.Byte POWER_SUPPLY_TECHNOLOGY_UNKNOWN => 0;
        public System.Byte POWER_SUPPLY_TECHNOLOGY_NIMH => 1;
        public System.Byte POWER_SUPPLY_TECHNOLOGY_LION => 2;
        public System.Byte POWER_SUPPLY_TECHNOLOGY_LIPO => 3;
        public System.Byte POWER_SUPPLY_TECHNOLOGY_LIFE => 4;
        public System.Byte POWER_SUPPLY_TECHNOLOGY_NICD => 5;
        public System.Byte POWER_SUPPLY_TECHNOLOGY_LIMN => 6;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single voltage
        {
            get;
            set;
        }

        public System.Single current
        {
            get;
            set;
        }

        public System.Single charge
        {
            get;
            set;
        }

        public System.Single capacity
        {
            get;
            set;
        }

        public System.Single design_capacity
        {
            get;
            set;
        }

        public System.Single percentage
        {
            get;
            set;
        }

        public System.Byte power_supply_status
        {
            get;
            set;
        }

        public System.Byte power_supply_health
        {
            get;
            set;
        }

        public System.Byte power_supply_technology
        {
            get;
            set;
        }

        public System.Boolean present
        {
            get;
            set;
        }

        public System.Single[] cell_voltage
        {
            get;
            set;
        }

        public System.String location
        {
            get;
            set;
        }

        public System.String serial_number
        {
            get;
            set;
        }

        public BatteryState(): base()
        {
        }

        public BatteryState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(voltage);
            binaryWriter.Write(current);
            binaryWriter.Write(charge);
            binaryWriter.Write(capacity);
            binaryWriter.Write(design_capacity);
            binaryWriter.Write(percentage);
            binaryWriter.Write(power_supply_status);
            binaryWriter.Write(power_supply_health);
            binaryWriter.Write(power_supply_technology);
            binaryWriter.Write(present);
            binaryWriter.Write(cell_voltage.Length); for  ( int  i  =  0 ;  i < cell_voltage . Length ;  i ++ ) binaryWriter . Write ( cell_voltage [ i ] ) ; 
            binaryWriter.Write(location.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( location ) ) ; 
            binaryWriter.Write(serial_number.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( serial_number ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            voltage = binaryReader.ReadSingle();
            current = binaryReader.ReadSingle();
            charge = binaryReader.ReadSingle();
            capacity = binaryReader.ReadSingle();
            design_capacity = binaryReader.ReadSingle();
            percentage = binaryReader.ReadSingle();
            power_supply_status = binaryReader.ReadByte();
            power_supply_health = binaryReader.ReadByte();
            power_supply_technology = binaryReader.ReadByte();
            present = binaryReader.ReadBoolean();
            cell_voltage = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cell_voltage . Length ;  i ++ ) cell_voltage [ i ]  =  binaryReader . ReadSingle ( ) ; 
            location = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            serial_number = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}