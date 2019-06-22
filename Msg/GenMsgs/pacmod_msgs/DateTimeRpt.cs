namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/DateTimeRpt", "2af1288975789a90586fd2529643798a", "Header header\n\nint32 year\nuint8 month\nuint8 day\nuint8 hour\nuint8 minute\nuint8 second\n\n")]
    public partial class DateTimeRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Int32 year
        {
            get;
            set;
        }

        public System.Byte month
        {
            get;
            set;
        }

        public System.Byte day
        {
            get;
            set;
        }

        public System.Byte hour
        {
            get;
            set;
        }

        public System.Byte minute
        {
            get;
            set;
        }

        public System.Byte second
        {
            get;
            set;
        }

        public DateTimeRpt(): base()
        {
        }

        public DateTimeRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(year);
            binaryWriter.Write(month);
            binaryWriter.Write(day);
            binaryWriter.Write(hour);
            binaryWriter.Write(minute);
            binaryWriter.Write(second);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            year = binaryReader.ReadInt32();
            month = binaryReader.ReadByte();
            day = binaryReader.ReadByte();
            hour = binaryReader.ReadByte();
            minute = binaryReader.ReadByte();
            second = binaryReader.ReadByte();
        }
    }
}