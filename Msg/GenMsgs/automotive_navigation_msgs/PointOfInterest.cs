namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/PointOfInterest", "e13bf4b872a022336936c4b575654650", @"# Point of Interest Message
# Contains the guid, latitude, longitude, and other information for a point of interest

uint64 guid        # Unique Id for this point

float64 latitude   # Latitude (degrees)
float64 longitude  # Longitude (degrees)

string params      # List of parameter:value pairs

")]
    public partial class PointOfInterest : RosMsg
    {
        public System.UInt64 guid
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

        public System.String @params
        {
            get;
            set;
        }

        public PointOfInterest(): base()
        {
        }

        public PointOfInterest(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(guid);
            binaryWriter.Write(latitude);
            binaryWriter.Write(longitude);
            binaryWriter.Write(@params.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( @params ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            guid = binaryReader.ReadUInt64();
            latitude = binaryReader.ReadDouble();
            longitude = binaryReader.ReadDouble();
            @params = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}