namespace Roslin.Msg.nmea_msgs
{
    [MsgInfo("nmea_msgs/Gprmc", "02533bac67f17457b2e3538525ba1aae", @"# Message from GPRMC NMEA String
Header header

string message_id

float64 utc_seconds
string position_status

float64 lat
float64 lon

string lat_dir
string lon_dir

float32 speed
float32 track
string date
float32 mag_var
string mag_var_direction
string mode_indicator
")]
    public partial class Gprmc : RosMsg
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

        public System.String position_status
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

        public System.Single speed
        {
            get;
            set;
        }

        public System.Single track
        {
            get;
            set;
        }

        public System.String date
        {
            get;
            set;
        }

        public System.Single mag_var
        {
            get;
            set;
        }

        public System.String mag_var_direction
        {
            get;
            set;
        }

        public System.String mode_indicator
        {
            get;
            set;
        }

        public Gprmc(): base()
        {
        }

        public Gprmc(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(message_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( message_id ) ) ; 
            binaryWriter.Write(utc_seconds);
            binaryWriter.Write(position_status.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( position_status ) ) ; 
            binaryWriter.Write(lat);
            binaryWriter.Write(lon);
            binaryWriter.Write(lat_dir.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( lat_dir ) ) ; 
            binaryWriter.Write(lon_dir.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( lon_dir ) ) ; 
            binaryWriter.Write(speed);
            binaryWriter.Write(track);
            binaryWriter.Write(date.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( date ) ) ; 
            binaryWriter.Write(mag_var);
            binaryWriter.Write(mag_var_direction.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( mag_var_direction ) ) ; 
            binaryWriter.Write(mode_indicator.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( mode_indicator ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            message_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            utc_seconds = binaryReader.ReadDouble();
            position_status = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            lat = binaryReader.ReadDouble();
            lon = binaryReader.ReadDouble();
            lat_dir = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            lon_dir = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            speed = binaryReader.ReadSingle();
            track = binaryReader.ReadSingle();
            date = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            mag_var = binaryReader.ReadSingle();
            mag_var_direction = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            mode_indicator = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}