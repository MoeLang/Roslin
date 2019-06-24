namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/DetectedObjectRpt", "bc712b16be2ea6767f3e682c00a854bc", @"Header header

float64 front_object_distance_low_res         # Measured distance to nearest front object
float64 front_object_distance_high_res        # Measured distance to nearest front object (high res)

")]
    public partial class DetectedObjectRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double front_object_distance_low_res
        {
            get;
            set;
        }

        public System.Double front_object_distance_high_res
        {
            get;
            set;
        }

        public DetectedObjectRpt(): base()
        {
        }

        public DetectedObjectRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(front_object_distance_low_res);
            binaryWriter.Write(front_object_distance_high_res);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            front_object_distance_low_res = binaryReader.ReadDouble();
            front_object_distance_high_res = binaryReader.ReadDouble();
        }
    }
}