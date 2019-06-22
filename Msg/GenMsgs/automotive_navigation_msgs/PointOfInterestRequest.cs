namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/PointOfInterestRequest", "32ddedb83d8866a4c42724a85ecf2c80", "# Point of Interest Request Message\n# Contains information needed to request point of interest information\n\nstd_msgs/Header header\n\nstring name        # Name of the point of interest list\n\nstring module_name # module name of the requesting node\n\nuint16 requestId   # Unique id of this request\n                   # Can make another request with the same requestId and\n                   # different update_num, guid, or tolerance.  New one will\n                   # replace the old one.\n\nuint16 cancel      # Set to 1 to cancel the request with this requestId\n\nuint16 update_num  # The update number of the point list to use\n\nuint16 guid_valid  # Request is for a specific point, not all points in list\nuint64 guid        # The unique Id for the desired point\n\nfloat32 tolerance  # How close to the current vehicle's position a point needs to be\n\n")]
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