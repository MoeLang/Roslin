namespace Roslin.Msg.bond
{
    [MsgInfo("bond/Constants", "6fc594dc1d7bd7919077042712f8c8b0", "float32 DEAD_PUBLISH_PERIOD = 0.05\nfloat32 DEFAULT_CONNECT_TIMEOUT = 10.0\nfloat32 DEFAULT_HEARTBEAT_TIMEOUT = 4.0\nfloat32 DEFAULT_DISCONNECT_TIMEOUT = 2.0\nfloat32 DEFAULT_HEARTBEAT_PERIOD = 1.0\n\nstring DISABLE_HEARTBEAT_TIMEOUT_PARAM=/bond_disable_heartbeat_timeout")]
    public partial class Constants : RosMsg
    {
        public System.Single DEAD_PUBLISH_PERIOD => 0.05f;
        public System.Single DEFAULT_CONNECT_TIMEOUT => 10.0f;
        public System.Single DEFAULT_HEARTBEAT_TIMEOUT => 4.0f;
        public System.Single DEFAULT_DISCONNECT_TIMEOUT => 2.0f;
        public System.Single DEFAULT_HEARTBEAT_PERIOD => 1.0f;
        public System.String DISABLE_HEARTBEAT_TIMEOUT_PARAM => "/bond_disable_heartbeat_timeout";
        public Constants(): base()
        {
        }

        public Constants(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
        }
    }
}