namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SimpleOccupancyGrid", "25fb4ce5a31aab052ba1250fcdda9da7", @"Header header
# plane coefficients
float32[4] coefficients
# cells
float32 resolution
geometry_msgs/Point[] cells
")]
    public partial class SimpleOccupancyGrid : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single[] coefficients
        {
            get;
            set;
        }

        public System.Single resolution
        {
            get;
            set;
        }

        public geometry_msgs.Point[] cells
        {
            get;
            set;
        }

        public SimpleOccupancyGrid(): base()
        {
        }

        public SimpleOccupancyGrid(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            for (int i = 0; i < 4; i++)
                binaryWriter.Write(coefficients[i]);
            binaryWriter.Write(resolution);
            binaryWriter.Write(cells.Length); for  ( int  i  =  0 ;  i < cells . Length ;  i ++ ) cells [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            coefficients = new System.Single[4]; for  ( int  i  =  0 ;  i < 4 ;  i ++ ) coefficients [ i ]  =  binaryReader . ReadSingle ( ) ; 
            resolution = binaryReader.ReadSingle();
            cells = new geometry_msgs.Point[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cells . Length ;  i ++ ) cells [ i ]  =  new  geometry_msgs . Point ( binaryReader ) ; 
        }
    }
}