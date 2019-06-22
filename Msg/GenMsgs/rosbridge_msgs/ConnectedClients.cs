namespace Roslin.Msg.rosbridge_msgs
{
    [MsgInfo("rosbridge_msgs/ConnectedClients", "d0d53b0c0aa23aa7e4cf52f49bca4b69", "ConnectedClient[] clients\n")]
    public partial class ConnectedClients : RosMsg
    {
        public ConnectedClient[] clients
        {
            get;
            set;
        }

        public ConnectedClients(): base()
        {
        }

        public ConnectedClients(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(clients.Length); for  ( int  i  =  0 ;  i < clients . Length ;  i ++ ) clients [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            clients = new ConnectedClient[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < clients . Length ;  i ++ ) clients [ i ]  =  new  ConnectedClient ( binaryReader ) ; 
        }
    }
}