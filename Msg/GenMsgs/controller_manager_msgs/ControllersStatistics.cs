namespace Roslin.Msg.controller_manager_msgs
{
    [MsgInfo("controller_manager_msgs/ControllersStatistics", "a154c347736773e3700d1719105df29d", "std_msgs/Header header\ncontroller_manager_msgs/ControllerStatistics[] controller\n")]
    public partial class ControllersStatistics : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public controller_manager_msgs.ControllerStatistics[] controller
        {
            get;
            set;
        }

        public ControllersStatistics(): base()
        {
        }

        public ControllersStatistics(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(controller.Length); for  ( int  i  =  0 ;  i < controller . Length ;  i ++ ) controller [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            controller = new controller_manager_msgs.ControllerStatistics[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < controller . Length ;  i ++ ) controller [ i ]  =  new  controller_manager_msgs . ControllerStatistics ( binaryReader ) ; 
        }
    }
}