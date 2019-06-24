namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/MotorRpt1", "bc762724eccc08e26b60b6284460fe26", @"Header header

float64 current         # Motor current in Ampres
float64 position        # Motor position in Radians
")]
    public partial class MotorRpt1 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double current
        {
            get;
            set;
        }

        public System.Double position
        {
            get;
            set;
        }

        public MotorRpt1(): base()
        {
        }

        public MotorRpt1(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(current);
            binaryWriter.Write(position);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            current = binaryReader.ReadDouble();
            position = binaryReader.ReadDouble();
        }
    }
}