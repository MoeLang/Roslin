namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/LaneBoundary", "abba97913ebab3edef0c7c39a4ea132f", "# Lane Boundary Message\n# Contains an array of points and other details\n\nuint8 UNKNOWN=0\n\nuint8 SOLID=1\nuint8 DASHED=2\nuint8 SOLID_DASHED=3\nuint8 DASHED_SOLID=4\nuint8 SOLID_SOLID=5\nuint8 style\n\nuint8 WHITE=1\nuint8 YELLOW=2\nuint8 color\n\ngeometry_msgs/Point[] line\n\n")]
    public partial class LaneBoundary : RosMsg
    {
        public System.Byte UNKNOWN => 0;
        public System.Byte SOLID => 1;
        public System.Byte DASHED => 2;
        public System.Byte SOLID_DASHED => 3;
        public System.Byte DASHED_SOLID => 4;
        public System.Byte SOLID_SOLID => 5;
        public System.Byte WHITE => 1;
        public System.Byte YELLOW => 2;
        public System.Byte style
        {
            get;
            set;
        }

        public System.Byte color
        {
            get;
            set;
        }

        public geometry_msgs.Point[] line
        {
            get;
            set;
        }

        public LaneBoundary(): base()
        {
        }

        public LaneBoundary(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(style);
            binaryWriter.Write(color);
            binaryWriter.Write(line.Length); for  ( int  i  =  0 ;  i < line . Length ;  i ++ ) line [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            style = binaryReader.ReadByte();
            color = binaryReader.ReadByte();
            line = new geometry_msgs.Point[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < line . Length ;  i ++ ) line [ i ]  =  new  geometry_msgs . Point ( binaryReader ) ; 
        }
    }
}