namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/NavSatFix", "2d3a8cd499b9b4a0249fb98fd05cfa48", @"# Navigation Satellite fix for any Global Navigation Satellite System
#
# Specified using the WGS 84 reference ellipsoid

# header.stamp specifies the ROS time for this measurement (the
#        corresponding satellite time may be reported using the
#        sensor_msgs/TimeReference message).
#
# header.frame_id is the frame of reference reported by the satellite
#        receiver, usually the location of the antenna.  This is a
#        Euclidean frame relative to the vehicle, not a reference
#        ellipsoid.
Header header

# satellite fix status information
NavSatStatus status

# Latitude [degrees]. Positive is north of equator; negative is south.
float64 latitude

# Longitude [degrees]. Positive is east of prime meridian; negative is west.
float64 longitude

# Altitude [m]. Positive is above the WGS 84 ellipsoid
# (quiet NaN if no altitude is available).
float64 altitude

# Position covariance [m^2] defined relative to a tangential plane
# through the reported position. The components are East, North, and
# Up (ENU), in row-major order.
#
# Beware: this coordinate system exhibits singularities at the poles.

float64[9] position_covariance

# If the covariance of the fix is known, fill it in completely. If the
# GPS receiver provides the variance of each measurement, put them
# along the diagonal. If only Dilution of Precision is available,
# estimate an approximate covariance from that.

uint8 COVARIANCE_TYPE_UNKNOWN = 0
uint8 COVARIANCE_TYPE_APPROXIMATED = 1
uint8 COVARIANCE_TYPE_DIAGONAL_KNOWN = 2
uint8 COVARIANCE_TYPE_KNOWN = 3

uint8 position_covariance_type
")]
    public partial class NavSatFix : RosMsg
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

        public NavSatStatus status
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

        public NavSatFix(): base()
        {
        }

        public NavSatFix(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            status.Serilize(binaryWriter);
            binaryWriter.Write(latitude);
            binaryWriter.Write(longitude);
            binaryWriter.Write(altitude);
            for (int i = 0; i < 9; i++)
                binaryWriter.Write(position_covariance[i]);
            binaryWriter.Write(position_covariance_type);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            status = new NavSatStatus(binaryReader);
            latitude = binaryReader.ReadDouble();
            longitude = binaryReader.ReadDouble();
            altitude = binaryReader.ReadDouble();
            position_covariance = new System.Double[9]; for  ( int  i  =  0 ;  i < 9 ;  i ++ ) position_covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
            position_covariance_type = binaryReader.ReadByte();
        }
    }
}