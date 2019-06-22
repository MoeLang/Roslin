namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Object", "57c53e712043df0244b0482d0447adee", "# object instant info (ex. oreo_cookie)\nint32 id  # object id\nstring name  # object name\n\n# object class info (ex. snack)\nint32 class_id\nstring class_name\n\nstring[] image_resources  # image urls\nstring mesh_resource  # mesh file url\n\nfloat32 weight  # weight [kg]\ngeometry_msgs/Vector3 dimensions  # bounding box [m]\n")]
    public partial class Object : RosMsg
    {
        public System.Int32 id
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public System.Int32 class_id
        {
            get;
            set;
        }

        public System.String class_name
        {
            get;
            set;
        }

        public System.String[] image_resources
        {
            get;
            set;
        }

        public System.String mesh_resource
        {
            get;
            set;
        }

        public System.Single weight
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 dimensions
        {
            get;
            set;
        }

        public Object(): base()
        {
        }

        public Object(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(id);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(class_id);
            binaryWriter.Write(class_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( class_name ) ) ; 
            binaryWriter.Write(image_resources.Length); for  ( int  i  =  0 ;  i < image_resources . Length ;  i ++ ) { binaryWriter . Write ( image_resources [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( image_resources [ i ] ) ) ;  }
            binaryWriter.Write(mesh_resource.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( mesh_resource ) ) ; 
            binaryWriter.Write(weight);
            dimensions.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            id = binaryReader.ReadInt32();
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            class_id = binaryReader.ReadInt32();
            class_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            image_resources = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < image_resources . Length ;  i ++ ) image_resources [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            mesh_resource = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            weight = binaryReader.ReadSingle();
            dimensions = new geometry_msgs.Vector3(binaryReader);
        }
    }
}