namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/Group", "9e8cd9e9423c94823db3614dd8b1cf7a", @"string name
string type
ParamDescription[] parameters
int32 parent 
int32 id
")]
    public partial class Group : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.String type
        {
            get;
            set;
        }

        public ParamDescription[] parameters
        {
            get;
            set;
        }

        public System.Int32 parent
        {
            get;
            set;
        }

        public System.Int32 id
        {
            get;
            set;
        }

        public Group(): base()
        {
        }

        public Group(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(type.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( type ) ) ; 
            binaryWriter.Write(parameters.Length); for  ( int  i  =  0 ;  i < parameters . Length ;  i ++ ) parameters [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(parent);
            binaryWriter.Write(id);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            type = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            parameters = new ParamDescription[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < parameters . Length ;  i ++ ) parameters [ i ]  =  new  ParamDescription ( binaryReader ) ; 
            parent = binaryReader.ReadInt32();
            id = binaryReader.ReadInt32();
        }
    }
}