namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/ImageMarker", "1de93c67ec8858b831025a08fbf1b35c", "uint8 CIRCLE=0\nuint8 LINE_STRIP=1\nuint8 LINE_LIST=2\nuint8 POLYGON=3\nuint8 POINTS=4\n\nuint8 ADD=0\nuint8 REMOVE=1\n\nHeader header\nstring ns		# namespace, used with id to form a unique id\nint32 id          	# unique id within the namespace\nint32 type        	# CIRCLE/LINE_STRIP/etc.\nint32 action      	# ADD/REMOVE\ngeometry_msgs/Point position # 2D, in pixel-coords\nfloat32 scale	 	# the diameter for a circle, etc.\nstd_msgs/ColorRGBA outline_color\nuint8 filled		# whether to fill in the shape with color\nstd_msgs/ColorRGBA fill_color # color [0.0-1.0]\nduration lifetime       # How long the object should last before being automatically deleted.  0 means forever\n\n\ngeometry_msgs/Point[] points # used for LINE_STRIP/LINE_LIST/POINTS/etc., 2D in pixel coords\nstd_msgs/ColorRGBA[] outline_colors # a color for each line, point, etc.")]
    public partial class ImageMarker : RosMsg
    {
        public System.Byte CIRCLE => 0;
        public System.Byte LINE_STRIP => 1;
        public System.Byte LINE_LIST => 2;
        public System.Byte POLYGON => 3;
        public System.Byte POINTS => 4;
        public System.Byte ADD => 0;
        public System.Byte REMOVE => 1;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String ns
        {
            get;
            set;
        }

        public System.Int32 id
        {
            get;
            set;
        }

        public System.Int32 type
        {
            get;
            set;
        }

        public System.Int32 action
        {
            get;
            set;
        }

        public geometry_msgs.Point position
        {
            get;
            set;
        }

        public System.Single scale
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA outline_color
        {
            get;
            set;
        }

        public System.Byte filled
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA fill_color
        {
            get;
            set;
        }

        public System.TimeSpan lifetime
        {
            get;
            set;
        }

        public geometry_msgs.Point[] points
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA[] outline_colors
        {
            get;
            set;
        }

        public ImageMarker(): base()
        {
        }

        public ImageMarker(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(ns.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( ns ) ) ; 
            binaryWriter.Write(id);
            binaryWriter.Write(type);
            binaryWriter.Write(action);
            position.Serilize(binaryWriter);
            binaryWriter.Write(scale);
            outline_color.Serilize(binaryWriter);
            binaryWriter.Write(filled);
            fill_color.Serilize(binaryWriter);
            binaryWriter.Write(lifetime);
            binaryWriter.Write(points.Length); for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(outline_colors.Length); for  ( int  i  =  0 ;  i < outline_colors . Length ;  i ++ ) outline_colors [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            ns = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            id = binaryReader.ReadInt32();
            type = binaryReader.ReadInt32();
            action = binaryReader.ReadInt32();
            position = new geometry_msgs.Point(binaryReader);
            scale = binaryReader.ReadSingle();
            outline_color = new std_msgs.ColorRGBA(binaryReader);
            filled = binaryReader.ReadByte();
            fill_color = new std_msgs.ColorRGBA(binaryReader);
            lifetime = binaryReader.ReadTimeSpan();
            points = new geometry_msgs.Point[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ]  =  new  geometry_msgs . Point ( binaryReader ) ; 
            outline_colors = new std_msgs.ColorRGBA[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < outline_colors . Length ;  i ++ ) outline_colors [ i ]  =  new  std_msgs . ColorRGBA ( binaryReader ) ; 
        }
    }
}