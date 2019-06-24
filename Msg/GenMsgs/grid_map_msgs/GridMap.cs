namespace Roslin.Msg.grid_map_msgs
{
    [MsgInfo("grid_map_msgs/GridMap", "95681e052b1f73bf87b7eb984382b401", @"# Grid map header
GridMapInfo info

# Grid map layer names.
string[] layers

# Grid map basic layer names (optional). The basic layers
# determine which layers from `layers` need to be valid
# in order for a cell of the grid map to be valid.
string[] basic_layers

# Grid map data.
std_msgs/Float32MultiArray[] data

# Row start index (default 0).
uint16 outer_start_index

# Column start index (default 0).
uint16 inner_start_index
")]
    public partial class GridMap : RosMsg
    {
        public GridMapInfo info
        {
            get;
            set;
        }

        public System.String[] layers
        {
            get;
            set;
        }

        public System.String[] basic_layers
        {
            get;
            set;
        }

        public std_msgs.Float32MultiArray[] data
        {
            get;
            set;
        }

        public System.UInt16 outer_start_index
        {
            get;
            set;
        }

        public System.UInt16 inner_start_index
        {
            get;
            set;
        }

        public GridMap(): base()
        {
        }

        public GridMap(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            info.Serilize(binaryWriter);
            binaryWriter.Write(layers.Length); for  ( int  i  =  0 ;  i < layers . Length ;  i ++ ) { binaryWriter . Write ( layers [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( layers [ i ] ) ) ;  }
            binaryWriter.Write(basic_layers.Length); for  ( int  i  =  0 ;  i < basic_layers . Length ;  i ++ ) { binaryWriter . Write ( basic_layers [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( basic_layers [ i ] ) ) ;  }
            binaryWriter.Write(data.Length); for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(outer_start_index);
            binaryWriter.Write(inner_start_index);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            info = new GridMapInfo(binaryReader);
            layers = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < layers . Length ;  i ++ ) layers [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            basic_layers = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < basic_layers . Length ;  i ++ ) basic_layers [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            data = new std_msgs.Float32MultiArray[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  new  std_msgs . Float32MultiArray ( binaryReader ) ; 
            outer_start_index = binaryReader.ReadUInt16();
            inner_start_index = binaryReader.ReadUInt16();
        }
    }
}