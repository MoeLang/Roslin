namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/CabinReport", "63611b37cea8020053088e5a34aead53", @"# Status of vehicle cabin sensors
Header header

# The door positions below are from the point of view of someone sitting
# in the vehicle, facing the X positive direction. Not using driver/passenger
# since this is different in left- vs right-hand drive vehicles.
bool door_open_front_right       # Status of the door nearest the front of the vehicle in the Y+ direction
bool door_open_front_left        # Status of the door nearest the front of the vehicle in the Y- direction
bool door_open_rear_right        # Status of the door nearest the rear of the vehicle in the Y+ direction
bool door_open_rear_left         # Status of the door nearest the rear of the vehicle in the Y- direction
bool hood_open                   # Status of the front compartment cover
bool trunk_open                  # Status of the rear compartment cover

bool passenger_present           # Whether or not a passenger is detected in the front non-driving seat
bool passenger_airbag_enabled    # Whether or not the passenger-side airbag is enabled

bool seatbelt_engaged_driver     # Whether or not the seatbelt for the driver's seat is buckled
bool seatbelt_engaged_passenger  # Whether or not the seatbelt for the passenger's seat is buckled
")]
    public partial class CabinReport : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean door_open_front_right
        {
            get;
            set;
        }

        public System.Boolean door_open_front_left
        {
            get;
            set;
        }

        public System.Boolean door_open_rear_right
        {
            get;
            set;
        }

        public System.Boolean door_open_rear_left
        {
            get;
            set;
        }

        public System.Boolean hood_open
        {
            get;
            set;
        }

        public System.Boolean trunk_open
        {
            get;
            set;
        }

        public System.Boolean passenger_present
        {
            get;
            set;
        }

        public System.Boolean passenger_airbag_enabled
        {
            get;
            set;
        }

        public System.Boolean seatbelt_engaged_driver
        {
            get;
            set;
        }

        public System.Boolean seatbelt_engaged_passenger
        {
            get;
            set;
        }

        public CabinReport(): base()
        {
        }

        public CabinReport(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(door_open_front_right);
            binaryWriter.Write(door_open_front_left);
            binaryWriter.Write(door_open_rear_right);
            binaryWriter.Write(door_open_rear_left);
            binaryWriter.Write(hood_open);
            binaryWriter.Write(trunk_open);
            binaryWriter.Write(passenger_present);
            binaryWriter.Write(passenger_airbag_enabled);
            binaryWriter.Write(seatbelt_engaged_driver);
            binaryWriter.Write(seatbelt_engaged_passenger);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            door_open_front_right = binaryReader.ReadBoolean();
            door_open_front_left = binaryReader.ReadBoolean();
            door_open_rear_right = binaryReader.ReadBoolean();
            door_open_rear_left = binaryReader.ReadBoolean();
            hood_open = binaryReader.ReadBoolean();
            trunk_open = binaryReader.ReadBoolean();
            passenger_present = binaryReader.ReadBoolean();
            passenger_airbag_enabled = binaryReader.ReadBoolean();
            seatbelt_engaged_driver = binaryReader.ReadBoolean();
            seatbelt_engaged_passenger = binaryReader.ReadBoolean();
        }
    }
}