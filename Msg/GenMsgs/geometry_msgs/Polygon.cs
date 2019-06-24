namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Polygon", "cd60a26494a087f577976f0329fa120e", @"#A specification of a polygon where the first and last points are assumed to be connected
Point32[] points
")]
    public partial class Polygon : RosMsg
    {
        public Point32[] points
        {
            get;
            set;
        }

        public Polygon(): base()
        {
        }

        public Polygon(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(points.Length); for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            points = new Point32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ]  =  new  Point32 ( binaryReader ) ; 
        }
    }
}