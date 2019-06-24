namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/ConfigDescription", "757ce9d44ba8ddd801bb30bc456f946f", @"Group[] groups
Config max
Config min
Config dflt
")]
    public partial class ConfigDescription : RosMsg
    {
        public Group[] groups
        {
            get;
            set;
        }

        public Config max
        {
            get;
            set;
        }

        public Config min
        {
            get;
            set;
        }

        public Config dflt
        {
            get;
            set;
        }

        public ConfigDescription(): base()
        {
        }

        public ConfigDescription(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(groups.Length); for  ( int  i  =  0 ;  i < groups . Length ;  i ++ ) groups [ i ] . Serilize ( binaryWriter ) ; 
            max.Serilize(binaryWriter);
            min.Serilize(binaryWriter);
            dflt.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            groups = new Group[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < groups . Length ;  i ++ ) groups [ i ]  =  new  Group ( binaryReader ) ; 
            max = new Config(binaryReader);
            min = new Config(binaryReader);
            dflt = new Config(binaryReader);
        }
    }
}