namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/MultiTouch", "9f4a309588ef669e69a71aa5601ea65e", @"Touch[] touches")]
    public partial class MultiTouch : RosMsg
    {
        public Touch[] touches
        {
            get;
            set;
        }

        public MultiTouch(): base()
        {
        }

        public MultiTouch(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(touches.Length); for  ( int  i  =  0 ;  i < touches . Length ;  i ++ ) touches [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            touches = new Touch[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < touches . Length ;  i ++ ) touches [ i ]  =  new  Touch ( binaryReader ) ; 
        }
    }
}