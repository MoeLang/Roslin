namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/LatLonHeadingRpt", "137a7c22b052c703f38a29aa79de4e50", "Header header\n\nint8 latitude_degrees\nuint8 latitude_minutes\nuint8 latitude_seconds\nint8 longitude_degrees\nuint8 longitude_minutes\nuint8 longitude_seconds\nfloat64 heading\n")]
    public partial class LatLonHeadingRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.SByte latitude_degrees
        {
            get;
            set;
        }

        public System.Byte latitude_minutes
        {
            get;
            set;
        }

        public System.Byte latitude_seconds
        {
            get;
            set;
        }

        public System.SByte longitude_degrees
        {
            get;
            set;
        }

        public System.Byte longitude_minutes
        {
            get;
            set;
        }

        public System.Byte longitude_seconds
        {
            get;
            set;
        }

        public System.Double heading
        {
            get;
            set;
        }

        public LatLonHeadingRpt(): base()
        {
        }

        public LatLonHeadingRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(latitude_degrees);
            binaryWriter.Write(latitude_minutes);
            binaryWriter.Write(latitude_seconds);
            binaryWriter.Write(longitude_degrees);
            binaryWriter.Write(longitude_minutes);
            binaryWriter.Write(longitude_seconds);
            binaryWriter.Write(heading);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            latitude_degrees = binaryReader.ReadSByte();
            latitude_minutes = binaryReader.ReadByte();
            latitude_seconds = binaryReader.ReadByte();
            longitude_degrees = binaryReader.ReadSByte();
            longitude_minutes = binaryReader.ReadByte();
            longitude_seconds = binaryReader.ReadByte();
            heading = binaryReader.ReadDouble();
        }
    }
}