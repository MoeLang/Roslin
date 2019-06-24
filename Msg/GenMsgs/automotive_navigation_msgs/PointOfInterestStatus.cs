namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/PointOfInterestStatus", "3747ebda6c320e19738cf7561a6a689b", @"# Point of Interest Status Message
# Contains the distance, heading, a localized position of a point of interest

uint64 guid        # Unique Id for this point

float32 distance   # Great circle distance (meters)
float32 heading    # Heading (radians)
float32 x_position # Distance in front of the vehicle (meters)
float32 y_position # Distance to the left of the vehicle (meters)

string params      # List of parameter:value pairs

")]
    public partial class PointOfInterestStatus : RosMsg
    {
        public System.UInt64 guid
        {
            get;
            set;
        }

        public System.Single distance
        {
            get;
            set;
        }

        public System.Single heading
        {
            get;
            set;
        }

        public System.Single x_position
        {
            get;
            set;
        }

        public System.Single y_position
        {
            get;
            set;
        }

        public System.String @params
        {
            get;
            set;
        }

        public PointOfInterestStatus(): base()
        {
        }

        public PointOfInterestStatus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(guid);
            binaryWriter.Write(distance);
            binaryWriter.Write(heading);
            binaryWriter.Write(x_position);
            binaryWriter.Write(y_position);
            binaryWriter.Write(@params.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( @params ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            guid = binaryReader.ReadUInt64();
            distance = binaryReader.ReadSingle();
            heading = binaryReader.ReadSingle();
            x_position = binaryReader.ReadSingle();
            y_position = binaryReader.ReadSingle();
            @params = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}