namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/PointOfInterestResponse", "358e8fda302368ac6d7d1b651933b309", @"# Point of Interest Response Message
# Contains status information about the points within the threshold

std_msgs/Header header

string name             # Name of the point of interest list

string module_name      # module name of the requesting node

uint16 requestId        # Unique id of this request

uint16 update_num       # The update number of the point list to use

automotive_navigation_msgs/PointOfInterestStatus[] point_statuses # The status information
")]
    public partial class PointOfInterestResponse : RosMsg
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

        public System.UInt16 update_num
        {
            get;
            set;
        }

        public automotive_navigation_msgs.PointOfInterestStatus[] point_statuses
        {
            get;
            set;
        }

        public PointOfInterestResponse(): base()
        {
        }

        public PointOfInterestResponse(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(module_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( module_name ) ) ; 
            binaryWriter.Write(requestId);
            binaryWriter.Write(update_num);
            binaryWriter.Write(point_statuses.Length); for  ( int  i  =  0 ;  i < point_statuses . Length ;  i ++ ) point_statuses [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            module_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            requestId = binaryReader.ReadUInt16();
            update_num = binaryReader.ReadUInt16();
            point_statuses = new automotive_navigation_msgs.PointOfInterestStatus[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < point_statuses . Length ;  i ++ ) point_statuses [ i ]  =  new  automotive_navigation_msgs . PointOfInterestStatus ( binaryReader ) ; 
        }
    }
}