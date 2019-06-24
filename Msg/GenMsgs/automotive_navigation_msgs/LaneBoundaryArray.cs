namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/LaneBoundaryArray", "e9f7b0fe081428eb62b95139882c4d89", @"# Lane Boundary Array Message
# Contains an array of lane boundaries contained in a section or segment of road

automotive_navigation_msgs/LaneBoundary[] boundaries

")]
    public partial class LaneBoundaryArray : RosMsg
    {
        public automotive_navigation_msgs.LaneBoundary[] boundaries
        {
            get;
            set;
        }

        public LaneBoundaryArray(): base()
        {
        }

        public LaneBoundaryArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(boundaries.Length); for  ( int  i  =  0 ;  i < boundaries . Length ;  i ++ ) boundaries [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            boundaries = new automotive_navigation_msgs.LaneBoundary[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < boundaries . Length ;  i ++ ) boundaries [ i ]  =  new  automotive_navigation_msgs . LaneBoundary ( binaryReader ) ; 
        }
    }
}