namespace Roslin.Msg.nmea_msgs
{
    [MsgInfo("nmea_msgs/GpgsvSatellite", "d862f2ce05a26a83264a8add99c7b668", "# Satellite data structure used in GPGSV messages\n\n# PRN number of the satellite\n# GPS = 1..32\n# SBAS = 33..64\n# GLO = 65..96\nuint8 prn\n\n# Elevation, degrees. Maximum 90\nuint8 elevation\n\n# Azimuth, True North degrees. [0, 359]\nuint16 azimuth\n\n# Signal to noise ratio, 0-99 dB. -1 when null in NMEA sentence (not tracking)\nint8 snr\n")]
    public partial class GpgsvSatellite : RosMsg
    {
        public System.Byte prn
        {
            get;
            set;
        }

        public System.Byte elevation
        {
            get;
            set;
        }

        public System.UInt16 azimuth
        {
            get;
            set;
        }

        public System.SByte snr
        {
            get;
            set;
        }

        public GpgsvSatellite(): base()
        {
        }

        public GpgsvSatellite(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(prn);
            binaryWriter.Write(elevation);
            binaryWriter.Write(azimuth);
            binaryWriter.Write(snr);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            prn = binaryReader.ReadByte();
            elevation = binaryReader.ReadByte();
            azimuth = binaryReader.ReadUInt16();
            snr = binaryReader.ReadSByte();
        }
    }
}