namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/HeightmapConfig", "f2f90f6dd5aeedef48b062e1a4aabb89", @"float32 min_x
float32 max_x
float32 min_y
float32 max_y
")]
    public partial class HeightmapConfig : RosMsg
    {
        public System.Single min_x
        {
            get;
            set;
        }

        public System.Single max_x
        {
            get;
            set;
        }

        public System.Single min_y
        {
            get;
            set;
        }

        public System.Single max_y
        {
            get;
            set;
        }

        public HeightmapConfig(): base()
        {
        }

        public HeightmapConfig(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(min_x);
            binaryWriter.Write(max_x);
            binaryWriter.Write(min_y);
            binaryWriter.Write(max_y);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            min_x = binaryReader.ReadSingle();
            max_x = binaryReader.ReadSingle();
            min_y = binaryReader.ReadSingle();
            max_y = binaryReader.ReadSingle();
        }
    }
}