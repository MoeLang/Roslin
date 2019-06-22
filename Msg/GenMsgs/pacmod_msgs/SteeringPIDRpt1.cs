namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SteeringPIDRpt1", "7d86880faae06366294b6ade0660000a", "Header header\n\nfloat64 dt         # time since last PID iteration\nfloat64 Kp         # proportional gain term\nfloat64 Ki         # integral gain term\nfloat64 Kd         # differential gain term\n")]
    public partial class SteeringPIDRpt1 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double dt
        {
            get;
            set;
        }

        public System.Double Kp
        {
            get;
            set;
        }

        public System.Double Ki
        {
            get;
            set;
        }

        public System.Double Kd
        {
            get;
            set;
        }

        public SteeringPIDRpt1(): base()
        {
        }

        public SteeringPIDRpt1(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(dt);
            binaryWriter.Write(Kp);
            binaryWriter.Write(Ki);
            binaryWriter.Write(Kd);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            dt = binaryReader.ReadDouble();
            Kp = binaryReader.ReadDouble();
            Ki = binaryReader.ReadDouble();
            Kd = binaryReader.ReadDouble();
        }
    }
}