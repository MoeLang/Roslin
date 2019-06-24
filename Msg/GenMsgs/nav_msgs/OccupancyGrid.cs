namespace Roslin.Msg.nav_msgs
{
    [MsgInfo("nav_msgs/OccupancyGrid", "3381f2d731d4076ec5c71b0759edbe4e", @"# This represents a 2-D grid map, in which each cell represents the probability of
# occupancy.

Header header 

#MetaData for the map
MapMetaData info

# The map data, in row-major order, starting with (0,0).  Occupancy
# probabilities are in the range [0,100].  Unknown is -1.
int8[] data
")]
    public partial class OccupancyGrid : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public MapMetaData info
        {
            get;
            set;
        }

        public System.SByte[] data
        {
            get;
            set;
        }

        public OccupancyGrid(): base()
        {
        }

        public OccupancyGrid(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            info.Serilize(binaryWriter);
            binaryWriter.Write(data.Length); for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) binaryWriter . Write ( data [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            info = new MapMetaData(binaryReader);
            data = new System.SByte[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  binaryReader . ReadSByte ( ) ; 
        }
    }
}