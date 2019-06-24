namespace Roslin.Msg.controller_manager_msgs
{
    [MsgInfo("controller_manager_msgs/HardwareInterfaceResources", "f25b55cbf1d1f76e82e5ec9e83f76258", @"# Type of hardware interface
string hardware_interface
# List of resources belonging to the hardware interface
string[] resources
")]
    public partial class HardwareInterfaceResources : RosMsg
    {
        public System.String hardware_interface
        {
            get;
            set;
        }

        public System.String[] resources
        {
            get;
            set;
        }

        public HardwareInterfaceResources(): base()
        {
        }

        public HardwareInterfaceResources(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(hardware_interface.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( hardware_interface ) ) ; 
            binaryWriter.Write(resources.Length); for  ( int  i  =  0 ;  i < resources . Length ;  i ++ ) { binaryWriter . Write ( resources [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( resources [ i ] ) ) ;  }
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            hardware_interface = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            resources = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < resources . Length ;  i ++ ) resources [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
        }
    }
}