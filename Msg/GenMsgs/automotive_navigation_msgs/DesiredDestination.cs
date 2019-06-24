namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/DesiredDestination", "ebb7b7743d8a0ce286cd377c24111c3c", @"# Desired Destination Message
# Contains the location of a desired destination

Header header

uint8 msg_counter   # Increments each time a command is sent
                    # An acknowledge message should be published with this value

uint16 valid        # 1 if location should be used, 0 to cancel out previous location

float64 latitude    # Latitude of destination (rad)
float64 longitude   # Longitude of destination (rad)

")]
    public partial class DesiredDestination : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Byte msg_counter
        {
            get;
            set;
        }

        public System.UInt16 valid
        {
            get;
            set;
        }

        public System.Double latitude
        {
            get;
            set;
        }

        public System.Double longitude
        {
            get;
            set;
        }

        public DesiredDestination(): base()
        {
        }

        public DesiredDestination(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(msg_counter);
            binaryWriter.Write(valid);
            binaryWriter.Write(latitude);
            binaryWriter.Write(longitude);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            msg_counter = binaryReader.ReadByte();
            valid = binaryReader.ReadUInt16();
            latitude = binaryReader.ReadDouble();
            longitude = binaryReader.ReadDouble();
        }
    }
}