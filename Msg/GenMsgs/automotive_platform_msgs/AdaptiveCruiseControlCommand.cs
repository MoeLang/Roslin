namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/AdaptiveCruiseControlCommand", "45cb31c55c795766905c8d3ddf401e18", @"# Adaptive Cruise Control Command Message
# Contains commands to engage/disengage ACC or adjust the set points

Header header

uint8 msg_counter   # Increments each time a command is sent
                    # An acknowledge message should be published with this value

float32 set_speed   # Speed setpoint (m/sec)
uint16 set          # Engage ACC at the above speed set point
uint16 resume       # Resume ACC at previous speed set point
uint16 cancel       # Disengage ACC
uint16 speed_up     # Increase speed set point
uint16 slow_down    # Decrease speed set point
uint16 further      # Increase distance set point
uint16 closer       # Decrease distance set point

")]
    public partial class AdaptiveCruiseControlCommand : RosMsg
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

        public System.Single set_speed
        {
            get;
            set;
        }

        public System.UInt16 set
        {
            get;
            set;
        }

        public System.UInt16 resume
        {
            get;
            set;
        }

        public System.UInt16 cancel
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

        public AdaptiveCruiseControlCommand(): base()
        {
        }

        public AdaptiveCruiseControlCommand(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(msg_counter);
            binaryWriter.Write(set_speed);
            binaryWriter.Write(set);
            binaryWriter.Write(resume);
            binaryWriter.Write(cancel);
            binaryWriter.Write(speed_up);
            binaryWriter.Write(slow_down);
            binaryWriter.Write(further);
            binaryWriter.Write(closer);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            msg_counter = binaryReader.ReadByte();
            set_speed = binaryReader.ReadSingle();
            set = binaryReader.ReadUInt16();
            resume = binaryReader.ReadUInt16();
            cancel = binaryReader.ReadUInt16();
            speed_up = binaryReader.ReadUInt16();
            slow_down = binaryReader.ReadUInt16();
            further = binaryReader.ReadUInt16();
            closer = binaryReader.ReadUInt16();
        }
    }
}