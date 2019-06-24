namespace Roslin.Msg.rosapi
{
    [MsgInfo("rosapi/TypeDef", "bd8529b0edb168fde8dd58032743f1f7", @"string type
string[] fieldnames
string[] fieldtypes
int32[] fieldarraylen
string[] examples
")]
    public partial class TypeDef : RosMsg
    {
        public System.String type
        {
            get;
            set;
        }

        public System.String[] fieldnames
        {
            get;
            set;
        }

        public System.String[] fieldtypes
        {
            get;
            set;
        }

        public System.Int32[] fieldarraylen
        {
            get;
            set;
        }

        public System.String[] examples
        {
            get;
            set;
        }

        public TypeDef(): base()
        {
        }

        public TypeDef(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(type.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( type ) ) ; 
            binaryWriter.Write(fieldnames.Length); for  ( int  i  =  0 ;  i < fieldnames . Length ;  i ++ ) { binaryWriter . Write ( fieldnames [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( fieldnames [ i ] ) ) ;  }
            binaryWriter.Write(fieldtypes.Length); for  ( int  i  =  0 ;  i < fieldtypes . Length ;  i ++ ) { binaryWriter . Write ( fieldtypes [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( fieldtypes [ i ] ) ) ;  }
            binaryWriter.Write(fieldarraylen.Length); for  ( int  i  =  0 ;  i < fieldarraylen . Length ;  i ++ ) binaryWriter . Write ( fieldarraylen [ i ] ) ; 
            binaryWriter.Write(examples.Length); for  ( int  i  =  0 ;  i < examples . Length ;  i ++ ) { binaryWriter . Write ( examples [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( examples [ i ] ) ) ;  }
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            type = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            fieldnames = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < fieldnames . Length ;  i ++ ) fieldnames [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            fieldtypes = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < fieldtypes . Length ;  i ++ ) fieldtypes [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            fieldarraylen = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < fieldarraylen . Length ;  i ++ ) fieldarraylen [ i ]  =  binaryReader . ReadInt32 ( ) ; 
            examples = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < examples . Length ;  i ++ ) examples [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
        }
    }
}