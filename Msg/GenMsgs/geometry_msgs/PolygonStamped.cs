namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/PolygonStamped", "c6be8f7dc3bee7fe9e8d296070f53340", "# This represents a Polygon with reference coordinate frame and timestamp\nHeader header\nPolygon polygon\n")]
    public partial class PolygonStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Polygon polygon
        {
            get;
            set;
        }

        public PolygonStamped(): base()
        {
        }

        public PolygonStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            polygon.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            polygon = new Polygon(binaryReader);
        }
    }
}