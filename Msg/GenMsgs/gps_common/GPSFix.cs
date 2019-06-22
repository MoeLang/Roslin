namespace Roslin.Msg.gps_common
{
    [MsgInfo("gps_common/GPSFix", "3db3d0a7bc53054c67c528af84710b70", "# A more complete GPS fix to supplement sensor_msgs/NavSatFix.\nHeader header\n\nGPSStatus status\n\n# Latitude (degrees). Positive is north of equator; negative is south.\nfloat64 latitude\n\n# Longitude (degrees). Positive is east of prime meridian, negative west.\nfloat64 longitude\n\n# Altitude (meters). Positive is above reference (e.g., sea level).\nfloat64 altitude\n\n# Direction (degrees from north)\nfloat64 track\n\n# Ground speed (meters/second)\nfloat64 speed\n\n# Vertical speed (meters/second)\nfloat64 climb\n\n# Device orientation (units in degrees)\nfloat64 pitch\nfloat64 roll\nfloat64 dip\n\n# GPS time\nfloat64 time\n\n## Dilution of precision; Xdop<=0 means the value is unknown\n\n# Total (positional-temporal) dilution of precision\nfloat64 gdop\n\n# Positional (3D) dilution of precision\nfloat64 pdop\n\n# Horizontal dilution of precision\nfloat64 hdop\n\n# Vertical dilution of precision\nfloat64 vdop\n\n# Temporal dilution of precision\nfloat64 tdop\n\n## Uncertainty of measurement, 95% confidence\n\n# Spherical position uncertainty (meters) [epe]\nfloat64 err\n\n# Horizontal position uncertainty (meters) [eph]\nfloat64 err_horz\n\n# Vertical position uncertainty (meters) [epv]\nfloat64 err_vert\n\n# Track uncertainty (degrees) [epd]\nfloat64 err_track\n\n# Ground speed uncertainty (meters/second) [eps]\nfloat64 err_speed\n\n# Vertical speed uncertainty (meters/second) [epc]\nfloat64 err_climb\n\n# Temporal uncertainty [ept]\nfloat64 err_time\n\n# Orientation uncertainty (degrees)\nfloat64 err_pitch\nfloat64 err_roll\nfloat64 err_dip\n\n# Position covariance [m^2] defined relative to a tangential plane\n# through the reported position. The components are East, North, and\n# Up (ENU), in row-major order.\n\nfloat64[9] position_covariance\n\nuint8 COVARIANCE_TYPE_UNKNOWN = 0\nuint8 COVARIANCE_TYPE_APPROXIMATED = 1\nuint8 COVARIANCE_TYPE_DIAGONAL_KNOWN = 2\nuint8 COVARIANCE_TYPE_KNOWN = 3\n\nuint8 position_covariance_type\n\n")]
    public partial class GPSFix : RosMsg
    {
        public System.Byte COVARIANCE_TYPE_UNKNOWN => 0;
        public System.Byte COVARIANCE_TYPE_APPROXIMATED => 1;
        public System.Byte COVARIANCE_TYPE_DIAGONAL_KNOWN => 2;
        public System.Byte COVARIANCE_TYPE_KNOWN => 3;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public GPSStatus status
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

        public System.Double altitude
        {
            get;
            set;
        }

        public System.Double track
        {
            get;
            set;
        }

        public System.Double speed
        {
            get;
            set;
        }

        public System.Double climb
        {
            get;
            set;
        }

        public System.Double pitch
        {
            get;
            set;
        }

        public System.Double roll
        {
            get;
            set;
        }

        public System.Double dip
        {
            get;
            set;
        }

        public System.Double time
        {
            get;
            set;
        }

        public System.Double gdop
        {
            get;
            set;
        }

        public System.Double pdop
        {
            get;
            set;
        }

        public System.Double hdop
        {
            get;
            set;
        }

        public System.Double vdop
        {
            get;
            set;
        }

        public System.Double tdop
        {
            get;
            set;
        }

        public System.Double err
        {
            get;
            set;
        }

        public System.Double err_horz
        {
            get;
            set;
        }

        public System.Double err_vert
        {
            get;
            set;
        }

        public System.Double err_track
        {
            get;
            set;
        }

        public System.Double err_speed
        {
            get;
            set;
        }

        public System.Double err_climb
        {
            get;
            set;
        }

        public System.Double err_time
        {
            get;
            set;
        }

        public System.Double err_pitch
        {
            get;
            set;
        }

        public System.Double err_roll
        {
            get;
            set;
        }

        public System.Double err_dip
        {
            get;
            set;
        }

        public System.Double[] position_covariance
        {
            get;
            set;
        }

        public System.Byte position_covariance_type
        {
            get;
            set;
        }

        public GPSFix(): base()
        {
        }

        public GPSFix(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            status.Serilize(binaryWriter);
            binaryWriter.Write(latitude);
            binaryWriter.Write(longitude);
            binaryWriter.Write(altitude);
            binaryWriter.Write(track);
            binaryWriter.Write(speed);
            binaryWriter.Write(climb);
            binaryWriter.Write(pitch);
            binaryWriter.Write(roll);
            binaryWriter.Write(dip);
            binaryWriter.Write(time);
            binaryWriter.Write(gdop);
            binaryWriter.Write(pdop);
            binaryWriter.Write(hdop);
            binaryWriter.Write(vdop);
            binaryWriter.Write(tdop);
            binaryWriter.Write(err);
            binaryWriter.Write(err_horz);
            binaryWriter.Write(err_vert);
            binaryWriter.Write(err_track);
            binaryWriter.Write(err_speed);
            binaryWriter.Write(err_climb);
            binaryWriter.Write(err_time);
            binaryWriter.Write(err_pitch);
            binaryWriter.Write(err_roll);
            binaryWriter.Write(err_dip);
            for (int i = 0; i < 9; i++)
                binaryWriter.Write(position_covariance[i]);
            binaryWriter.Write(position_covariance_type);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            status = new GPSStatus(binaryReader);
            latitude = binaryReader.ReadDouble();
            longitude = binaryReader.ReadDouble();
            altitude = binaryReader.ReadDouble();
            track = binaryReader.ReadDouble();
            speed = binaryReader.ReadDouble();
            climb = binaryReader.ReadDouble();
            pitch = binaryReader.ReadDouble();
            roll = binaryReader.ReadDouble();
            dip = binaryReader.ReadDouble();
            time = binaryReader.ReadDouble();
            gdop = binaryReader.ReadDouble();
            pdop = binaryReader.ReadDouble();
            hdop = binaryReader.ReadDouble();
            vdop = binaryReader.ReadDouble();
            tdop = binaryReader.ReadDouble();
            err = binaryReader.ReadDouble();
            err_horz = binaryReader.ReadDouble();
            err_vert = binaryReader.ReadDouble();
            err_track = binaryReader.ReadDouble();
            err_speed = binaryReader.ReadDouble();
            err_climb = binaryReader.ReadDouble();
            err_time = binaryReader.ReadDouble();
            err_pitch = binaryReader.ReadDouble();
            err_roll = binaryReader.ReadDouble();
            err_dip = binaryReader.ReadDouble();
            position_covariance = new System.Double[9]; for  ( int  i  =  0 ;  i < 9 ;  i ++ ) position_covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
            position_covariance_type = binaryReader.ReadByte();
        }
    }
}