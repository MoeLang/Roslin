namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/Tablet", "0bab196c7b214826d8c27d7bd5f924f6", "Header header\n# hardware_namel: iPad, Android, other mobile\nstring hardware_name\nstring hardware_id\nAction action\nDeviceSensor sensor\nTouch[] touches")]
    public partial class Tablet : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String hardware_name
        {
            get;
            set;
        }

        public System.String hardware_id
        {
            get;
            set;
        }

        public Action action
        {
            get;
            set;
        }

        public DeviceSensor sensor
        {
            get;
            set;
        }

        public Touch[] touches
        {
            get;
            set;
        }

        public Tablet(): base()
        {
        }

        public Tablet(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(hardware_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( hardware_name ) ) ; 
            binaryWriter.Write(hardware_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( hardware_id ) ) ; 
            action.Serilize(binaryWriter);
            sensor.Serilize(binaryWriter);
            binaryWriter.Write(touches.Length); for  ( int  i  =  0 ;  i < touches . Length ;  i ++ ) touches [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            hardware_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            hardware_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            action = new Action(binaryReader);
            sensor = new DeviceSensor(binaryReader);
            touches = new Touch[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < touches . Length ;  i ++ ) touches [ i ]  =  new  Touch ( binaryReader ) ; 
        }
    }
}