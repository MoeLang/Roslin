namespace Roslin.Msg.nmea_msgs
{
    [MsgInfo("nmea_msgs/Gpgsa", "94a6ef4a36d322374b16097a5d03433e", @"# Message from GPGSA NMEA String
Header header

string message_id

string auto_manual_mode
uint8 fix_mode

uint8[] sv_ids

float32 pdop
float32 hdop
float32 vdop
")]
    public partial class Gpgsa : RosMsg
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

        public System.String auto_manual_mode
        {
            get;
            set;
        }

        public System.Byte fix_mode
        {
            get;
            set;
        }

        public System.Byte[] sv_ids
        {
            get;
            set;
        }

        public System.Single pdop
        {
            get;
            set;
        }

        public System.Single hdop
        {
            get;
            set;
        }

        public System.Single vdop
        {
            get;
            set;
        }

        public Gpgsa(): base()
        {
        }

        public Gpgsa(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(message_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( message_id ) ) ; 
            binaryWriter.Write(auto_manual_mode.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( auto_manual_mode ) ) ; 
            binaryWriter.Write(fix_mode);
            binaryWriter.Write(sv_ids.Length); binaryWriter . Write ( sv_ids ) ; 
            binaryWriter.Write(pdop);
            binaryWriter.Write(hdop);
            binaryWriter.Write(vdop);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            message_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            auto_manual_mode = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            fix_mode = binaryReader.ReadByte();
            sv_ids = new System.Byte[binaryReader.ReadInt32()]; sv_ids  =  binaryReader . ReadBytes ( sv_ids . Length ) ; 
            pdop = binaryReader.ReadSingle();
            hdop = binaryReader.ReadSingle();
            vdop = binaryReader.ReadSingle();
        }
    }
}