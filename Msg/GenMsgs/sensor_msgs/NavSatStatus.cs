namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/NavSatStatus", "331cdbddfa4bc96ffc3b9ad98900a54c", "# Navigation Satellite fix status for any Global Navigation Satellite System\n\n# Whether to output an augmented fix is determined by both the fix\n# type and the last time differential corrections were received.  A\n# fix is valid when status >= STATUS_FIX.\n\nint8 STATUS_NO_FIX =  -1        # unable to fix position\nint8 STATUS_FIX =      0        # unaugmented fix\nint8 STATUS_SBAS_FIX = 1        # with satellite-based augmentation\nint8 STATUS_GBAS_FIX = 2        # with ground-based augmentation\n\nint8 status\n\n# Bits defining which Global Navigation Satellite System signals were\n# used by the receiver.\n\nuint16 SERVICE_GPS =     1\nuint16 SERVICE_GLONASS = 2\nuint16 SERVICE_COMPASS = 4      # includes BeiDou.\nuint16 SERVICE_GALILEO = 8\n\nuint16 service\n")]
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