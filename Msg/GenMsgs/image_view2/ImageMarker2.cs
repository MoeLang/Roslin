namespace Roslin.Msg.image_view2
{
    [MsgInfo("image_view2/ImageMarker2", "8efc23e411f94f2c04288719c078c291", @"byte CIRCLE=0
byte LINE_STRIP=1
byte LINE_LIST=2
byte POLYGON=3
byte POINTS=4
byte FRAMES=5
byte TEXT=6

byte LINE_STRIP3D=7
byte LINE_LIST3D=8
byte POLYGON3D=9
byte POINTS3D=10
byte TEXT3D=11
byte CIRCLE3D=12

byte ADD=0
byte REMOVE=1

Header header
string ns		# namespace, used with id to form a unique id
int32 id          	# unique id within the namespace
int32 type        	# CIRCLE/LINE_STRIP/etc.
int32 action      	# ADD/REMOVE
geometry_msgs/Point position # used for CIRCLE/TEXT, 2D in pixel-coords
geometry_msgs/PointStamped position3D # used for 3DTEXT
geometry_msgs/PoseStamped pose # used for CIRCLE3D
float32 scale	 	# the diameter for a circle, etc.
float32 width	 	# the width for a line, etc.
std_msgs/ColorRGBA outline_color
byte filled		# whether to fill in the shape with color
std_msgs/ColorRGBA fill_color # color [0.0-1.0]
duration lifetime       # How long the object should last before being automatically deleted.  0 means forever
byte arc # used for CIRCLE3D
float32 angle # used for CIRCLE3D


geometry_msgs/Point[] points # used for LINE_STRIP/LINE_LIST/POLYGON/POINTS., 2D in pixel coords
PointArrayStamped points3D # used for 3DLINE_STRIP/3DLINE_LIST/3DPOLYGON/3DPOINTS
std_msgs/ColorRGBA[] outline_colors # a color for each line, point, etc.

string[] frames # used for FRAMES, tf names
string text             # used for TEXT, draw size of text is scale
bool left_up_origin     # draw text from left up origin
bool ratio_scale        #Use ratio respected to original image to specify scale and position
")]
    public partial class ImageMarker2 : RosMsg
    {
        public System.Byte CIRCLE => 0;
        public System.Byte LINE_STRIP => 1;
        public System.Byte LINE_LIST => 2;
        public System.Byte POLYGON => 3;
        public System.Byte POINTS => 4;
        public System.Byte FRAMES => 5;
        public System.Byte TEXT => 6;
        public System.Byte LINE_STRIP3D => 7;
        public System.Byte LINE_LIST3D => 8;
        public System.Byte POLYGON3D => 9;
        public System.Byte POINTS3D => 10;
        public System.Byte TEXT3D => 11;
        public System.Byte CIRCLE3D => 12;
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

        public geometry_msgs.PointStamped position3D
        {
            get;
            set;
        }

        public geometry_msgs.PoseStamped pose
        {
            get;
            set;
        }

        public System.Single scale
        {
            get;
            set;
        }

        public System.Single width
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

        public System.Byte arc
        {
            get;
            set;
        }

        public System.Single angle
        {
            get;
            set;
        }

        public geometry_msgs.Point[] points
        {
            get;
            set;
        }

        public PointArrayStamped points3D
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA[] outline_colors
        {
            get;
            set;
        }

        public System.String[] frames
        {
            get;
            set;
        }

        public System.String text
        {
            get;
            set;
        }

        public System.Boolean left_up_origin
        {
            get;
            set;
        }

        public System.Boolean ratio_scale
        {
            get;
            set;
        }

        public ImageMarker2(): base()
        {
        }

        public ImageMarker2(System.IO.BinaryReader binaryReader): base(binaryReader)
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
            position3D.Serilize(binaryWriter);
            pose.Serilize(binaryWriter);
            binaryWriter.Write(scale);
            binaryWriter.Write(width);
            outline_color.Serilize(binaryWriter);
            binaryWriter.Write(filled);
            fill_color.Serilize(binaryWriter);
            binaryWriter.Write(lifetime);
            binaryWriter.Write(arc);
            binaryWriter.Write(angle);
            binaryWriter.Write(points.Length); for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ] . Serilize ( binaryWriter ) ; 
            points3D.Serilize(binaryWriter);
            binaryWriter.Write(outline_colors.Length); for  ( int  i  =  0 ;  i < outline_colors . Length ;  i ++ ) outline_colors [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(frames.Length); for  ( int  i  =  0 ;  i < frames . Length ;  i ++ ) { binaryWriter . Write ( frames [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( frames [ i ] ) ) ;  }
            binaryWriter.Write(text.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( text ) ) ; 
            binaryWriter.Write(left_up_origin);
            binaryWriter.Write(ratio_scale);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            ns = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            id = binaryReader.ReadInt32();
            type = binaryReader.ReadInt32();
            action = binaryReader.ReadInt32();
            position = new geometry_msgs.Point(binaryReader);
            position3D = new geometry_msgs.PointStamped(binaryReader);
            pose = new geometry_msgs.PoseStamped(binaryReader);
            scale = binaryReader.ReadSingle();
            width = binaryReader.ReadSingle();
            outline_color = new std_msgs.ColorRGBA(binaryReader);
            filled = binaryReader.ReadByte();
            fill_color = new std_msgs.ColorRGBA(binaryReader);
            lifetime = binaryReader.ReadTimeSpan();
            arc = binaryReader.ReadByte();
            angle = binaryReader.ReadSingle();
            points = new geometry_msgs.Point[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ]  =  new  geometry_msgs . Point ( binaryReader ) ; 
            points3D = new PointArrayStamped(binaryReader);
            outline_colors = new std_msgs.ColorRGBA[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < outline_colors . Length ;  i ++ ) outline_colors [ i ]  =  new  std_msgs . ColorRGBA ( binaryReader ) ; 
            frames = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < frames . Length ;  i ++ ) frames [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            text = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            left_up_origin = binaryReader.ReadBoolean();
            ratio_scale = binaryReader.ReadBoolean();
        }
    }
}