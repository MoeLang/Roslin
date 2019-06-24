namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/NavSatStatus", "331cdbddfa4bc96ffc3b9ad98900a54c", @"# Navigation Satellite fix status for any Global Navigation Satellite System

# Whether to output an augmented fix is determined by both the fix
# type and the last time differential corrections were received.  A
# fix is valid when status >= STATUS_FIX.

int8 STATUS_NO_FIX =  -1        # unable to fix position
int8 STATUS_FIX =      0        # unaugmented fix
int8 STATUS_SBAS_FIX = 1        # with satellite-based augmentation
int8 STATUS_GBAS_FIX = 2        # with ground-based augmentation

int8 status

# Bits defining which Global Navigation Satellite System signals were
# used by the receiver.

uint16 SERVICE_GPS =     1
uint16 SERVICE_GLONASS = 2
uint16 SERVICE_COMPASS = 4      # includes BeiDou.
uint16 SERVICE_GALILEO = 8

uint16 service
")]
    public partial class NavSatStatus : RosMsg
    {
        public System.SByte STATUS_NO_FIX => -1;
        public System.SByte STATUS_FIX => 0;
        public System.SByte STATUS_SBAS_FIX => 1;
        public System.SByte STATUS_GBAS_FIX => 2;
        public System.UInt16 SERVICE_GPS => 1;
        public System.UInt16 SERVICE_GLONASS => 2;
        public System.UInt16 SERVICE_COMPASS => 4;
        public System.UInt16 SERVICE_GALILEO => 8;
        public System.SByte status
        {
            get;
            set;
        }

        public System.UInt16 service
        {
            get;
            set;
        }

        public NavSatStatus(): base()
        {
        }

        public NavSatStatus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(status);
            binaryWriter.Write(service);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            status = binaryReader.ReadSByte();
            service = binaryReader.ReadUInt16();
        }
    }
}