namespace Roslin.Msg.nmea_msgs
{
    [MsgInfo("nmea_msgs/Gpgga", "8f51cb504898f39d8ad9f698f0b6f9cd", "# Message from GPGGA NMEA String\nHeader header\n\nstring message_id\n\n# UTC seconds from midnight\nfloat64 utc_seconds\n\nfloat64 lat\nfloat64 lon\n\nstring lat_dir\nstring lon_dir\n\nuint32 gps_qual\n\nuint32 num_sats\nfloat32 hdop \nfloat32 alt\nstring altitude_units\n\nfloat32 undulation\nstring undulation_units\nuint32 diff_age\nstring station_id\n")]
    public partial class Gpgga : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String message_id
        {
            get;
            set;
        }

        public System.Double utc_seconds
        {
            get;
            set;
        }

        public System.Double lat
        {
            get;
            set;
        }

        public System.Double lon
        {
            get;
            set;
        }

        public System.String lat_dir
        {
            get;
            set;
        }

        public System.String lon_dir
        {
            get;
            set;
        }

        public System.UInt32 gps_qual
        {
            get;
            set;
        }

        public System.UInt32 num_sats
        {
            get;
            set;
        }

        public System.Single hdop
        {
            get;
            set;
        }

        public System.Single alt
        {
            get;
            set;
        }

        public System.String altitude_units
        {
            get;
            set;
        }

        public System.Single undulation
        {
            get;
            set;
        }

        public System.String undulation_units
        {
            get;
            set;
        }

        public System.UInt32 diff_age
        {
            get;
            set;
        }

        public System.String station_id
        {
            get;
            set;
        }

        public Gpgga(): base()
        {
        }

        public Gpgga(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(message_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( message_id ) ) ; 
            binaryWriter.Write(utc_seconds);
            binaryWriter.Write(lat);
            binaryWriter.Write(lon);
            binaryWriter.Write(lat_dir.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( lat_dir ) ) ; 
            binaryWriter.Write(lon_dir.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( lon_dir ) ) ; 
            binaryWriter.Write(gps_qual);
            binaryWriter.Write(num_sats);
            binaryWriter.Write(hdop);
            binaryWriter.Write(alt);
            binaryWriter.Write(altitude_units.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( altitude_units ) ) ; 
            binaryWriter.Write(undulation);
            binaryWriter.Write(undulation_units.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( undulation_units ) ) ; 
            binaryWriter.Write(diff_age);
            binaryWriter.Write(station_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( station_id ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            message_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            utc_seconds = binaryReader.ReadDouble();
            lat = binaryReader.ReadDouble();
            lon = binaryReader.ReadDouble();
            lat_dir = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            lon_dir = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            gps_qual = binaryReader.ReadUInt32();
            num_sats = binaryReader.ReadUInt32();
            hdop = binaryReader.ReadSingle();
            alt = binaryReader.ReadSingle();
            altitude_units = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            undulation = binaryReader.ReadSingle();
            undulation_units = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            diff_age = binaryReader.ReadUInt32();
            station_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}