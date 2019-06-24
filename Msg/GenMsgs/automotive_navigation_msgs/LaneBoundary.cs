namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/LaneBoundary", "abba97913ebab3edef0c7c39a4ea132f", @"# Lane Boundary Message
# Contains an array of points and other details

uint8 UNKNOWN=0

uint8 SOLID=1
uint8 DASHED=2
uint8 SOLID_DASHED=3
uint8 DASHED_SOLID=4
uint8 SOLID_SOLID=5
uint8 style

uint8 WHITE=1
uint8 YELLOW=2
uint8 color

geometry_msgs/Point[] line

")]
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