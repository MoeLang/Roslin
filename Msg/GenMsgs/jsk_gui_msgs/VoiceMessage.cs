namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/VoiceMessage", "8d7dcfb3b46640ccf02177a3f0cf9530", "string[] texts")]
    public partial class VoiceMessage : RosMsg
    {
        public System.String[] texts
        {
            get;
            set;
        }

        public VoiceMessage(): base()
        {
        }

        public VoiceMessage(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(texts.Length); for  ( int  i  =  0 ;  i < texts . Length ;  i ++ ) { binaryWriter . Write ( texts [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( texts [ i ] ) ) ;  }
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            texts = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < texts . Length ;  i ++ ) texts [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
        }
    }
}