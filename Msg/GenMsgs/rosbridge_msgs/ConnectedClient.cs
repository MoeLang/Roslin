namespace Roslin.Msg.rosbridge_msgs
{
    [MsgInfo("rosbridge_msgs/ConnectedClient", "7f2187ce389b39b2b3bb2a3957e54c04", "string ip_address\ntime connection_time\n")]
    public partial class ConnectedClient : RosMsg
    {
        public System.String ip_address
        {
            get;
            set;
        }

        public System.DateTime connection_time
        {
            get;
            set;
        }

        public ConnectedClient(): base()
        {
        }

        public ConnectedClient(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(ip_address.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( ip_address ) ) ; 
            binaryWriter.Write(connection_time);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            ip_address = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            connection_time = binaryReader.ReadDateTime();
        }
    }
}