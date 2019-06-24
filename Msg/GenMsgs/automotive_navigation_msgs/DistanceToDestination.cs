namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/DistanceToDestination", "5900bd7ec809d5e8d6ec47b8ddef8d1b", @"# Distance To Destination Message
# Contains the distance to the desired destination

Header header

uint8 msg_counter   # Increments each time a command is sent
                    # An acknowledge message should be published with this value

float32 distance    # Distance to destination (m)

")]
    public partial class DistanceToDestination : RosMsg
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

        public System.Single distance
        {
            get;
            set;
        }

        public DistanceToDestination(): base()
        {
        }

        public DistanceToDestination(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(msg_counter);
            binaryWriter.Write(distance);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            msg_counter = binaryReader.ReadByte();
            distance = binaryReader.ReadSingle();
        }
    }
}