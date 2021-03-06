namespace Roslin.Msg.nmea_msgs
{
    [MsgInfo("nmea_msgs/Gpgsv", "6f34bebc32fe085313c942a96fd39c77", @"# Total number of satellites in view and data about satellites
# Because the NMEA sentence is limited to 4 satellites per message, several
# of these messages may need to be synthesized to get data about all visible
# satellites.

Header header

string message_id

# Number of messages in this sequence
uint8 n_msgs
# This messages number in its sequence. The first message is number 1.
uint8 msg_number

# Number of satellites currently visible
uint8 n_satellites

# Up to 4 satellites are described in each message
GpgsvSatellite[] satellites
")]
    public partial class Gpgsv : RosMsg
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

        public System.Byte n_msgs
        {
            get;
            set;
        }

        public System.Byte msg_number
        {
            get;
            set;
        }

        public System.Byte n_satellites
        {
            get;
            set;
        }

        public GpgsvSatellite[] satellites
        {
            get;
            set;
        }

        public Gpgsv(): base()
        {
        }

        public Gpgsv(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(message_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( message_id ) ) ; 
            binaryWriter.Write(n_msgs);
            binaryWriter.Write(msg_number);
            binaryWriter.Write(n_satellites);
            binaryWriter.Write(satellites.Length); for  ( int  i  =  0 ;  i < satellites . Length ;  i ++ ) satellites [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            message_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            n_msgs = binaryReader.ReadByte();
            msg_number = binaryReader.ReadByte();
            n_satellites = binaryReader.ReadByte();
            satellites = new GpgsvSatellite[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < satellites . Length ;  i ++ ) satellites [ i ]  =  new  GpgsvSatellite ( binaryReader ) ; 
        }
    }
}