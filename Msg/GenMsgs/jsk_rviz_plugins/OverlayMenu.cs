namespace Roslin.Msg.jsk_rviz_plugins
{
    [MsgInfo("jsk_rviz_plugins/OverlayMenu", "fed3c7e9788f7ee37908107a2597b619", @"int32 ACTION_SELECT=0
int32 ACTION_CLOSE=1
int32 action
uint32 current_index
string[] menus
string title
")]
    public partial class OverlayMenu : RosMsg
    {
        public System.Int32 ACTION_SELECT => 0;
        public System.Int32 ACTION_CLOSE => 1;
        public System.Int32 action
        {
            get;
            set;
        }

        public System.UInt32 current_index
        {
            get;
            set;
        }

        public System.String[] menus
        {
            get;
            set;
        }

        public System.String title
        {
            get;
            set;
        }

        public OverlayMenu(): base()
        {
        }

        public OverlayMenu(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(action);
            binaryWriter.Write(current_index);
            binaryWriter.Write(menus.Length); for  ( int  i  =  0 ;  i < menus . Length ;  i ++ ) { binaryWriter . Write ( menus [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( menus [ i ] ) ) ;  }
            binaryWriter.Write(title.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( title ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            action = binaryReader.ReadInt32();
            current_index = binaryReader.ReadUInt32();
            menus = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < menus . Length ;  i ++ ) menus [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            title = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}