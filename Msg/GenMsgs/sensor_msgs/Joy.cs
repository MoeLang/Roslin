namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/Joy", "5a9ea5f83505693b71e785041e67a8bb", @"# Reports the state of a joysticks axes and buttons.
Header header           # timestamp in the header is the time the data is received from the joystick
float32[] axes          # the axes measurements from a joystick
int32[] buttons         # the buttons measurements from a joystick 
")]
    public partial class Joy : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single[] axes
        {
            get;
            set;
        }

        public System.Int32[] buttons
        {
            get;
            set;
        }

        public Joy(): base()
        {
        }

        public Joy(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(axes.Length); for  ( int  i  =  0 ;  i < axes . Length ;  i ++ ) binaryWriter . Write ( axes [ i ] ) ; 
            binaryWriter.Write(buttons.Length); for  ( int  i  =  0 ;  i < buttons . Length ;  i ++ ) binaryWriter . Write ( buttons [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            axes = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < axes . Length ;  i ++ ) axes [ i ]  =  binaryReader . ReadSingle ( ) ; 
            buttons = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < buttons . Length ;  i ++ ) buttons [ i ]  =  binaryReader . ReadInt32 ( ) ; 
        }
    }
}