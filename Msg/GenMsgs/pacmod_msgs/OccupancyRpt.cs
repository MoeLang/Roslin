namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/OccupancyRpt", "0721e1bb580b55ac7fd96411e39adf3e", @"Header header

bool driver_seat_occupied
bool driver_seat_occupied_is_valid
bool passenger_seat_occupied
bool passenger_seat_occupied_is_valid
bool rear_seat_occupied
bool rear_seat_occupied_is_valid
bool driver_seatbelt_buckled
bool driver_seatbelt_buckled_is_valid
bool passenger_seatbelt_buckled
bool passenger_seatbelt_buckled_is_valid
bool rear_seatbelt_buckled
bool rear_seatbelt_buckled_is_valid
")]
    public partial class OccupancyRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean driver_seat_occupied
        {
            get;
            set;
        }

        public System.Boolean driver_seat_occupied_is_valid
        {
            get;
            set;
        }

        public System.Boolean passenger_seat_occupied
        {
            get;
            set;
        }

        public System.Boolean passenger_seat_occupied_is_valid
        {
            get;
            set;
        }

        public System.Boolean rear_seat_occupied
        {
            get;
            set;
        }

        public System.Boolean rear_seat_occupied_is_valid
        {
            get;
            set;
        }

        public System.Boolean driver_seatbelt_buckled
        {
            get;
            set;
        }

        public System.Boolean driver_seatbelt_buckled_is_valid
        {
            get;
            set;
        }

        public System.Boolean passenger_seatbelt_buckled
        {
            get;
            set;
        }

        public System.Boolean passenger_seatbelt_buckled_is_valid
        {
            get;
            set;
        }

        public System.Boolean rear_seatbelt_buckled
        {
            get;
            set;
        }

        public System.Boolean rear_seatbelt_buckled_is_valid
        {
            get;
            set;
        }

        public OccupancyRpt(): base()
        {
        }

        public OccupancyRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(driver_seat_occupied);
            binaryWriter.Write(driver_seat_occupied_is_valid);
            binaryWriter.Write(passenger_seat_occupied);
            binaryWriter.Write(passenger_seat_occupied_is_valid);
            binaryWriter.Write(rear_seat_occupied);
            binaryWriter.Write(rear_seat_occupied_is_valid);
            binaryWriter.Write(driver_seatbelt_buckled);
            binaryWriter.Write(driver_seatbelt_buckled_is_valid);
            binaryWriter.Write(passenger_seatbelt_buckled);
            binaryWriter.Write(passenger_seatbelt_buckled_is_valid);
            binaryWriter.Write(rear_seatbelt_buckled);
            binaryWriter.Write(rear_seatbelt_buckled_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            driver_seat_occupied = binaryReader.ReadBoolean();
            driver_seat_occupied_is_valid = binaryReader.ReadBoolean();
            passenger_seat_occupied = binaryReader.ReadBoolean();
            passenger_seat_occupied_is_valid = binaryReader.ReadBoolean();
            rear_seat_occupied = binaryReader.ReadBoolean();
            rear_seat_occupied_is_valid = binaryReader.ReadBoolean();
            driver_seatbelt_buckled = binaryReader.ReadBoolean();
            driver_seatbelt_buckled_is_valid = binaryReader.ReadBoolean();
            passenger_seatbelt_buckled = binaryReader.ReadBoolean();
            passenger_seatbelt_buckled_is_valid = binaryReader.ReadBoolean();
            rear_seatbelt_buckled = binaryReader.ReadBoolean();
            rear_seatbelt_buckled_is_valid = binaryReader.ReadBoolean();
        }
    }
}