namespace Roslin.Msg.map_msgs
{
    [MsgInfo("map_msgs/ProjectedMapInfo", "2dc10595ae94de23f22f8a6d2a0eef7a", "string frame_id\nfloat64 x\nfloat64 y\nfloat64 width\nfloat64 height\nfloat64 min_z\nfloat64 max_z")]
    public partial class ProjectedMapInfo : RosMsg
    {
        public System.String frame_id
        {
            get;
            set;
        }

        public System.Double x
        {
            get;
            set;
        }

        public System.Double y
        {
            get;
            set;
        }

        public System.Double width
        {
            get;
            set;
        }

        public System.Double height
        {
            get;
            set;
        }

        public System.Double min_z
        {
            get;
            set;
        }

        public System.Double max_z
        {
            get;
            set;
        }

        public ProjectedMapInfo(): base()
        {
        }

        public ProjectedMapInfo(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(frame_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( frame_id ) ) ; 
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(width);
            binaryWriter.Write(height);
            binaryWriter.Write(min_z);
            binaryWriter.Write(max_z);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            frame_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            x = binaryReader.ReadDouble();
            y = binaryReader.ReadDouble();
            width = binaryReader.ReadDouble();
            height = binaryReader.ReadDouble();
            min_z = binaryReader.ReadDouble();
            max_z = binaryReader.ReadDouble();
        }
    }
}