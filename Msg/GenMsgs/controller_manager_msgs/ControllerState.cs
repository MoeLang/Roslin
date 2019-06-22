namespace Roslin.Msg.controller_manager_msgs
{
    [MsgInfo("controller_manager_msgs/ControllerState", "aeb6b261d97793ab74099a3740245272", "string name\nstring state\nstring type\ncontroller_manager_msgs/HardwareInterfaceResources[] claimed_resources\n")]
    public partial class ControllerState : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.String state
        {
            get;
            set;
        }

        public System.String type
        {
            get;
            set;
        }

        public controller_manager_msgs.HardwareInterfaceResources[] claimed_resources
        {
            get;
            set;
        }

        public ControllerState(): base()
        {
        }

        public ControllerState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(state.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( state ) ) ; 
            binaryWriter.Write(type.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( type ) ) ; 
            binaryWriter.Write(claimed_resources.Length); for  ( int  i  =  0 ;  i < claimed_resources . Length ;  i ++ ) claimed_resources [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            state = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            type = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            claimed_resources = new controller_manager_msgs.HardwareInterfaceResources[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < claimed_resources . Length ;  i ++ ) claimed_resources [ i ]  =  new  controller_manager_msgs . HardwareInterfaceResources ( binaryReader ) ; 
        }
    }
}