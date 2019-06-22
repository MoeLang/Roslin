namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/PointOfInterestArray", "23d123c6723540d685425f0f725601ab", "# Point of Interest List Message\n# Contains an array of points of interest\n# update_num is incremented each time a new list is sent\n\nstd_msgs/Header header\nuint16 update_num\nautomotive_navigation_msgs/PointOfInterest[] point_list\n")]
    public partial class PointOfInterestArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt16 update_num
        {
            get;
            set;
        }

        public automotive_navigation_msgs.PointOfInterest[] point_list
        {
            get;
            set;
        }

        public PointOfInterestArray(): base()
        {
        }

        public PointOfInterestArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(update_num);
            binaryWriter.Write(point_list.Length); for  ( int  i  =  0 ;  i < point_list . Length ;  i ++ ) point_list [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            update_num = binaryReader.ReadUInt16();
            point_list = new automotive_navigation_msgs.PointOfInterest[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < point_list . Length ;  i ++ ) point_list [ i ]  =  new  automotive_navigation_msgs . PointOfInterest ( binaryReader ) ; 
        }
    }
}