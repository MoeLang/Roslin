namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/CurvatureFeedback", "5c011af0547a17c89a2ebf5e6e57bd57", "# Current Curvature Feedback\n# Curvature based on steering sensor feedback\n\nstd_msgs/Header header\n\nfloat32 curvature           # Measured steering curvature (1/m)\n\n\n")]
    public partial class CurvatureFeedback : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single curvature
        {
            get;
            set;
        }

        public CurvatureFeedback(): base()
        {
        }

        public CurvatureFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(curvature);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            curvature = binaryReader.ReadSingle();
        }
    }
}