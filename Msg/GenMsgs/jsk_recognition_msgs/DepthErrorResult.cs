namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/DepthErrorResult", "cebbb2d000457fe5d971a29ee02ffb16", @"Header header
uint32 u
uint32 v
float32 center_u
float32 center_v
float32 true_depth
float32 observed_depth
")]
    public partial class DepthErrorResult : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt32 u
        {
            get;
            set;
        }

        public System.UInt32 v
        {
            get;
            set;
        }

        public System.Single center_u
        {
            get;
            set;
        }

        public System.Single center_v
        {
            get;
            set;
        }

        public System.Single true_depth
        {
            get;
            set;
        }

        public System.Single observed_depth
        {
            get;
            set;
        }

        public DepthErrorResult(): base()
        {
        }

        public DepthErrorResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(u);
            binaryWriter.Write(v);
            binaryWriter.Write(center_u);
            binaryWriter.Write(center_v);
            binaryWriter.Write(true_depth);
            binaryWriter.Write(observed_depth);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            u = binaryReader.ReadUInt32();
            v = binaryReader.ReadUInt32();
            center_u = binaryReader.ReadSingle();
            center_v = binaryReader.ReadSingle();
            true_depth = binaryReader.ReadSingle();
            observed_depth = binaryReader.ReadSingle();
        }
    }
}