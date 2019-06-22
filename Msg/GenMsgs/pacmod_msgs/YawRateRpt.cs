namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/YawRateRpt", "8bdabba36ff5a4751eb3ad99f74991ca", "Header header\n\nfloat64 yaw_rate    #In rad/s.\n")]
    public partial class YawRateRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double yaw_rate
        {
            get;
            set;
        }

        public YawRateRpt(): base()
        {
        }

        public YawRateRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(yaw_rate);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            yaw_rate = binaryReader.ReadDouble();
        }
    }
}