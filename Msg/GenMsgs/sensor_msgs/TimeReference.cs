namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/TimeReference", "fded64a0265108ba86c3d38fb11c0c16", "# Measurement from an external time source not actively synchronized with the system clock.\n\nHeader header    # stamp is system time for which measurement was valid\n                 # frame_id is not used \n\ntime   time_ref  # corresponding time from this external source\nstring source    # (optional) name of time source\n")]
    public partial class TimeReference : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.DateTime time_ref
        {
            get;
            set;
        }

        public System.String source
        {
            get;
            set;
        }

        public TimeReference(): base()
        {
        }

        public TimeReference(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(time_ref);
            binaryWriter.Write(source.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( source ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            time_ref = binaryReader.ReadDateTime();
            source = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}