namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/DriverCommands", "612c1e59d97aa5ea3be1c2ad2b26dbc7", "# Driver Commands Message\n# Contains commands from the driver to the autonomy system\n\nuint8 msg_counter   # Increments each time a command is sent\n                    # An acknowledge message should be published with this value\n\nuint16 engage       # Engage auto\nuint16 disengage    # Disengage auto\nuint16 speed_up     # Increase speed set point\nuint16 slow_down    # Decrease speed set point\nuint16 further      # Increase distance set point\nuint16 closer       # Decrease distance set point\nuint16 right_turn   # Right turn signal\nuint16 left_turn    # Left turn signal\n\n")]
    public partial class DriverCommands : RosMsg
    {
        public System.Byte msg_counter
        {
            get;
            set;
        }

        public System.UInt16 engage
        {
            get;
            set;
        }

        public System.UInt16 disengage
        {
            get;
            set;
        }

        public System.UInt16 speed_up
        {
            get;
            set;
        }

        public System.UInt16 slow_down
        {
            get;
            set;
        }

        public System.UInt16 further
        {
            get;
            set;
        }

        public System.UInt16 closer
        {
            get;
            set;
        }

        public System.UInt16 right_turn
        {
            get;
            set;
        }

        public System.UInt16 left_turn
        {
            get;
            set;
        }

        public DriverCommands(): base()
        {
        }

        public DriverCommands(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(msg_counter);
            binaryWriter.Write(engage);
            binaryWriter.Write(disengage);
            binaryWriter.Write(speed_up);
            binaryWriter.Write(slow_down);
            binaryWriter.Write(further);
            binaryWriter.Write(closer);
            binaryWriter.Write(right_turn);
            binaryWriter.Write(left_turn);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            msg_counter = binaryReader.ReadByte();
            engage = binaryReader.ReadUInt16();
            disengage = binaryReader.ReadUInt16();
            speed_up = binaryReader.ReadUInt16();
            slow_down = binaryReader.ReadUInt16();
            further = binaryReader.ReadUInt16();
            closer = binaryReader.ReadUInt16();
            right_turn = binaryReader.ReadUInt16();
            left_turn = binaryReader.ReadUInt16();
        }
    }
}