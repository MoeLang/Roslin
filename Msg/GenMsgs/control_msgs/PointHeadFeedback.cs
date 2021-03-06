namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/PointHeadFeedback", "cce80d27fd763682da8805a73316cab4", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
float64 pointing_angle_error

")]
    public partial class PointHeadFeedback : RosMsg
    {
        public System.Double pointing_angle_error
        {
            get;
            set;
        }

        public PointHeadFeedback(): base()
        {
        }

        public PointHeadFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(pointing_angle_error);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            pointing_angle_error = binaryReader.ReadDouble();
        }
    }
}