namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/PolygonArray", "709b37d39871cfdbbfbd5c41cf9bc2be", "# PolygonArray is a list of PolygonStamped.\n# You can use jsk_rviz_plugins to visualize PolygonArray on rviz.\nHeader header\ngeometry_msgs/PolygonStamped[] polygons\nuint32[] labels\nfloat32[] likelihood\n")]
    public partial class PolygonArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.PolygonStamped[] polygons
        {
            get;
            set;
        }

        public System.UInt32[] labels
        {
            get;
            set;
        }

        public System.Single[] likelihood
        {
            get;
            set;
        }

        public PolygonArray(): base()
        {
        }

        public PolygonArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(polygons.Length); for  ( int  i  =  0 ;  i < polygons . Length ;  i ++ ) polygons [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(labels.Length); for  ( int  i  =  0 ;  i < labels . Length ;  i ++ ) binaryWriter . Write ( labels [ i ] ) ; 
            binaryWriter.Write(likelihood.Length); for  ( int  i  =  0 ;  i < likelihood . Length ;  i ++ ) binaryWriter . Write ( likelihood [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            polygons = new geometry_msgs.PolygonStamped[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < polygons . Length ;  i ++ ) polygons [ i ]  =  new  geometry_msgs . PolygonStamped ( binaryReader ) ; 
            labels = new System.UInt32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < labels . Length ;  i ++ ) labels [ i ]  =  binaryReader . ReadUInt32 ( ) ; 
            likelihood = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < likelihood . Length ;  i ++ ) likelihood [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}