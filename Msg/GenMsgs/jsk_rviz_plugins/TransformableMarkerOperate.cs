namespace Roslin.Msg.jsk_rviz_plugins
{
    [MsgInfo("jsk_rviz_plugins/TransformableMarkerOperate", "3f5042567d7e11634fa94e4b5452169c", "uint8 BOX=0\nuint8 CYLINDER=1\nuint8 TORUS=2\nuint8 MESH_RESOURCE=3\n\nuint8 INSERT=0\nuint8 ERASE=1\nuint8 ERASEALL=2\nuint8 ERASEFOCUS=3\nuint8 COPY=4\n\nint32 type\nint32 action\nstring frame_id\nstring name\nstring description\nstring mesh_resource\nbool mesh_use_embedded_materials")]
    public partial class TransformableMarkerOperate : RosMsg
    {
        public System.Byte BOX => 0;
        public System.Byte CYLINDER => 1;
        public System.Byte TORUS => 2;
        public System.Byte MESH_RESOURCE => 3;
        public System.Byte INSERT => 0;
        public System.Byte ERASE => 1;
        public System.Byte ERASEALL => 2;
        public System.Byte ERASEFOCUS => 3;
        public System.Byte COPY => 4;
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

        public System.String frame_id
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public System.String description
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

        public TransformableMarkerOperate(): base()
        {
        }

        public TransformableMarkerOperate(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(type);
            binaryWriter.Write(action);
            binaryWriter.Write(frame_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( frame_id ) ) ; 
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(description.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( description ) ) ; 
            binaryWriter.Write(mesh_resource.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( mesh_resource ) ) ; 
            binaryWriter.Write(mesh_use_embedded_materials);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            type = binaryReader.ReadInt32();
            action = binaryReader.ReadInt32();
            frame_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            description = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            mesh_resource = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            mesh_use_embedded_materials = binaryReader.ReadBoolean();
        }
    }
}