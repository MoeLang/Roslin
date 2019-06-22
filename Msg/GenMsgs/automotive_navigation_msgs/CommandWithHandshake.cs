namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/CommandWithHandshake", "0bc28bf48c6bf23450157ae0aab75d4e", "# General Command Message\n# Contains a command and a message counter that can be used for handshaking\n\nstd_msgs/Header header\n\nuint8 msg_counter   # Increments each time a command is sent\n                    # An acknowledge message should be published with this value\n\nint16 command       # The command value\n\n")]
    public partial class CommandWithHandshake : RosMsg
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

        public System.Int16 command
        {
            get;
            set;
        }

        public CommandWithHandshake(): base()
        {
        }

        public CommandWithHandshake(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(msg_counter);
            binaryWriter.Write(command);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            msg_counter = binaryReader.ReadByte();
            command = binaryReader.ReadInt16();
        }
    }
}