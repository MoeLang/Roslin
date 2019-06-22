namespace Roslin.Msg.nav_msgs
{
    [MsgInfo("nav_msgs/GridCells", "b9e4f5df6d28e272ebde00a3994830f5", "#an array of cells in a 2D grid\nHeader header\nfloat32 cell_width\nfloat32 cell_height\ngeometry_msgs/Point[] cells\n")]
    public partial class GridCells : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single cell_width
        {
            get;
            set;
        }

        public System.Single cell_height
        {
            get;
            set;
        }

        public geometry_msgs.Point[] cells
        {
            get;
            set;
        }

        public GridCells(): base()
        {
        }

        public GridCells(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(cell_width);
            binaryWriter.Write(cell_height);
            binaryWriter.Write(cells.Length); for  ( int  i  =  0 ;  i < cells . Length ;  i ++ ) cells [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            cell_width = binaryReader.ReadSingle();
            cell_height = binaryReader.ReadSingle();
            cells = new geometry_msgs.Point[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cells . Length ;  i ++ ) cells [ i ]  =  new  geometry_msgs . Point ( binaryReader ) ; 
        }
    }
}