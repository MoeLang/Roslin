namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/JoyFeedbackArray", "cde5730a895b1fc4dee6f91b754b213d", "# This message publishes values for multiple feedback at once. \nJoyFeedback[] array")]
    public partial class JoyFeedbackArray : RosMsg
    {
        public JoyFeedback[] array
        {
            get;
            set;
        }

        public JoyFeedbackArray(): base()
        {
        }

        public JoyFeedbackArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(array.Length); for  ( int  i  =  0 ;  i < array . Length ;  i ++ ) array [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            array = new JoyFeedback[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < array . Length ;  i ++ ) array [ i ]  =  new  JoyFeedback ( binaryReader ) ; 
        }
    }
}