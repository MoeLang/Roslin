namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/DoorRpt", "a2ffa235d04f8d5d5e349a5d9caead12", "Header header\n\nbool driver_door_open\nbool driver_door_open_is_valid\nbool passenger_door_open\nbool passenger_door_open_is_valid\nbool rear_driver_door_open\nbool rear_driver_door_open_is_valid\nbool rear_passenger_door_open\nbool rear_passenger_door_open_is_valid\nbool hood_open\nbool hood_open_is_valid\nbool trunk_open\nbool trunk_open_is_valid\nbool fuel_door_open\nbool fuel_door_open_is_valid\n")]
    public partial class DoorRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean driver_door_open
        {
            get;
            set;
        }

        public System.Boolean driver_door_open_is_valid
        {
            get;
            set;
        }

        public System.Boolean passenger_door_open
        {
            get;
            set;
        }

        public System.Boolean passenger_door_open_is_valid
        {
            get;
            set;
        }

        public System.Boolean rear_driver_door_open
        {
            get;
            set;
        }

        public System.Boolean rear_driver_door_open_is_valid
        {
            get;
            set;
        }

        public System.Boolean rear_passenger_door_open
        {
            get;
            set;
        }

        public System.Boolean rear_passenger_door_open_is_valid
        {
            get;
            set;
        }

        public System.Boolean hood_open
        {
            get;
            set;
        }

        public System.Boolean hood_open_is_valid
        {
            get;
            set;
        }

        public System.Boolean trunk_open
        {
            get;
            set;
        }

        public System.Boolean trunk_open_is_valid
        {
            get;
            set;
        }

        public System.Boolean fuel_door_open
        {
            get;
            set;
        }

        public System.Boolean fuel_door_open_is_valid
        {
            get;
            set;
        }

        public DoorRpt(): base()
        {
        }

        public DoorRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(driver_door_open);
            binaryWriter.Write(driver_door_open_is_valid);
            binaryWriter.Write(passenger_door_open);
            binaryWriter.Write(passenger_door_open_is_valid);
            binaryWriter.Write(rear_driver_door_open);
            binaryWriter.Write(rear_driver_door_open_is_valid);
            binaryWriter.Write(rear_passenger_door_open);
            binaryWriter.Write(rear_passenger_door_open_is_valid);
            binaryWriter.Write(hood_open);
            binaryWriter.Write(hood_open_is_valid);
            binaryWriter.Write(trunk_open);
            binaryWriter.Write(trunk_open_is_valid);
            binaryWriter.Write(fuel_door_open);
            binaryWriter.Write(fuel_door_open_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            driver_door_open = binaryReader.ReadBoolean();
            driver_door_open_is_valid = binaryReader.ReadBoolean();
            passenger_door_open = binaryReader.ReadBoolean();
            passenger_door_open_is_valid = binaryReader.ReadBoolean();
            rear_driver_door_open = binaryReader.ReadBoolean();
            rear_driver_door_open_is_valid = binaryReader.ReadBoolean();
            rear_passenger_door_open = binaryReader.ReadBoolean();
            rear_passenger_door_open_is_valid = binaryReader.ReadBoolean();
            hood_open = binaryReader.ReadBoolean();
            hood_open_is_valid = binaryReader.ReadBoolean();
            trunk_open = binaryReader.ReadBoolean();
            trunk_open_is_valid = binaryReader.ReadBoolean();
            fuel_door_open = binaryReader.ReadBoolean();
            fuel_door_open_is_valid = binaryReader.ReadBoolean();
        }
    }
}