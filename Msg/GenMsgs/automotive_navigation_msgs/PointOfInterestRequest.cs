namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/PointOfInterestRequest", "32ddedb83d8866a4c42724a85ecf2c80", @"# Point of Interest Request Message
# Contains information needed to request point of interest information

std_msgs/Header header

string name        # Name of the point of interest list

string module_name # module name of the requesting node

uint16 requestId   # Unique id of this request
                   # Can make another request with the same requestId and
                   # different update_num, guid, or tolerance.  New one will
                   # replace the old one.

uint16 cancel      # Set to 1 to cancel the request with this requestId

uint16 update_num  # The update number of the point list to use

uint16 guid_valid  # Request is for a specific point, not all points in list
uint64 guid        # The unique Id for the desired point

float32 tolerance  # How close to the current vehicle's position a point needs to be

")]
    public partial class PointOfInterestRequest : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public System.String module_name
        {
            get;
            set;
        }

        public System.UInt16 requestId
        {
            get;
            set;
        }

        public System.UInt16 cancel
        {
            get;
            set;
        }

        public System.UInt16 update_num
        {
            get;
            set;
        }

        public System.UInt16 guid_valid
        {
            get;
            set;
        }

        public System.UInt64 guid
        {
            get;
            set;
        }

        public System.Single tolerance
        {
            get;
            set;
        }

        public PointOfInterestRequest(): base()
        {
        }

        public PointOfInterestRequest(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(module_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( module_name ) ) ; 
            binaryWriter.Write(requestId);
            binaryWriter.Write(cancel);
            binaryWriter.Write(update_num);
            binaryWriter.Write(guid_valid);
            binaryWriter.Write(guid);
            binaryWriter.Write(tolerance);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            module_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            requestId = binaryReader.ReadUInt16();
            cancel = binaryReader.ReadUInt16();
            update_num = binaryReader.ReadUInt16();
            guid_valid = binaryReader.ReadUInt16();
            guid = binaryReader.ReadUInt64();
            tolerance = binaryReader.ReadSingle();
        }
    }
}