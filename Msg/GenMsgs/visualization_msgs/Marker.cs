namespace Roslin.Msg.visualization_msgs
{
    [MsgInfo("visualization_msgs/Marker", "4048c9de2a16f4ae8e0538085ebf1b97", "# See http://www.ros.org/wiki/rviz/DisplayTypes/Marker and http://www.ros.org/wiki/rviz/Tutorials/Markers%3A%20Basic%20Shapes for more information on using this message with rviz\n\nuint8 ARROW=0\nuint8 CUBE=1\nuint8 SPHERE=2\nuint8 CYLINDER=3\nuint8 LINE_STRIP=4\nuint8 LINE_LIST=5\nuint8 CUBE_LIST=6\nuint8 SPHERE_LIST=7\nuint8 POINTS=8\nuint8 TEXT_VIEW_FACING=9\nuint8 MESH_RESOURCE=10\nuint8 TRIANGLE_LIST=11\n\nuint8 ADD=0\nuint8 MODIFY=0\nuint8 DELETE=2\nuint8 DELETEALL=3\n\nHeader header                        # header for time/frame information\nstring ns                            # Namespace to place this object in... used in conjunction with id to create a unique name for the object\nint32 id 		                         # object ID useful in conjunction with the namespace for manipulating and deleting the object later\nint32 type 		                       # Type of object\nint32 action 	                       # 0 add/modify an object, 1 (deprecated), 2 deletes an object, 3 deletes all objects\ngeometry_msgs/Pose pose                 # Pose of the object\ngeometry_msgs/Vector3 scale             # Scale of the object 1,1,1 means default (usually 1 meter square)\nstd_msgs/ColorRGBA color             # Color [0.0-1.0]\nduration lifetime                    # How long the object should last before being automatically deleted.  0 means forever\nbool frame_locked                    # If this marker should be frame-locked, i.e. retransformed into its frame every timestep\n\n#Only used if the type specified has some use for them (eg. POINTS, LINE_STRIP, ...)\ngeometry_msgs/Point[] points\n#Only used if the type specified has some use for them (eg. POINTS, LINE_STRIP, ...)\n#number of colors must either be 0 or equal to the number of points\n#NOTE: alpha is not yet used\nstd_msgs/ColorRGBA[] colors\n\n# NOTE: only used for text markers\nstring text\n\n# NOTE: only used for MESH_RESOURCE markers\nstring mesh_resource\nbool mesh_use_embedded_materials\n")]
    public partial class Marker : RosMsg
    {
        public System.Byte ARROW => 0;
        public System.Byte CUBE => 1;
        public System.Byte SPHERE => 2;
        public System.Byte CYLINDER => 3;
        public System.Byte LINE_STRIP => 4;
        public System.Byte LINE_LIST => 5;
        public System.Byte CUBE_LIST => 6;
        public System.Byte SPHERE_LIST => 7;
        public System.Byte POINTS => 8;
        public System.Byte TEXT_VIEW_FACING => 9;
        public System.Byte MESH_RESOURCE => 10;
        public System.Byte TRIANGLE_LIST => 11;
        public System.Byte ADD => 0;
        public System.Byte MODIFY => 0;
        public System.Byte DELETE => 2;
        public System.Byte DELETEALL => 3;
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

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 scale
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA color
        {
            get;
            set;
        }

        public System.TimeSpan lifetime
        {
            get;
            set;
        }

        public System.Boolean frame_locked
        {
            get;
            set;
        }

        public geometry_msgs.Point[] points
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA[] colors
        {
            get;
            set;
        }

        public System.String text
        {
            get;
            set;
        }

        public System.String mesh_resource
        {
            get;
            set;
        }

        public System.Boolean mesh_use_embedded_materials
        {
            get;
            set;
        }

        public Marker(): base()
        {
        }

        public Marker(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(ns.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( ns ) ) ; 
            binaryWriter.Write(id);
            binaryWriter.Write(type);
            binaryWriter.Write(action);
            pose.Serilize(binaryWriter);
            scale.Serilize(binaryWriter);
            color.Serilize(binaryWriter);
            binaryWriter.Write(lifetime);
            binaryWriter.Write(frame_locked);
            binaryWriter.Write(points.Length); for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(colors.Length); for  ( int  i  =  0 ;  i < colors . Length ;  i ++ ) colors [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(text.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( text ) ) ; 
            binaryWriter.Write(mesh_resource.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( mesh_resource ) ) ; 
            binaryWriter.Write(mesh_use_embedded_materials);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            ns = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            id = binaryReader.ReadInt32();
            type = binaryReader.ReadInt32();
            action = binaryReader.ReadInt32();
            pose = new geometry_msgs.Pose(binaryReader);
            scale = new geometry_msgs.Vector3(binaryReader);
            color = new std_msgs.ColorRGBA(binaryReader);
            lifetime = binaryReader.ReadTimeSpan();
            frame_locked = binaryReader.ReadBoolean();
            points = new geometry_msgs.Point[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < points . Length ;  i ++ ) points [ i ]  =  new  geometry_msgs . Point ( binaryReader ) ; 
            colors = new std_msgs.ColorRGBA[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < colors . Length ;  i ++ ) colors [ i ]  =  new  std_msgs . ColorRGBA ( binaryReader ) ; 
            text = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            mesh_resource = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            mesh_use_embedded_materials = binaryReader.ReadBoolean();
        }
    }
}