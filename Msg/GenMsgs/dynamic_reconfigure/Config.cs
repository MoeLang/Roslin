namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/Config", "958f16a05573709014982821e6822580", @"BoolParameter[] bools
IntParameter[] ints
StrParameter[] strs
DoubleParameter[] doubles
GroupState[] groups
")]
    public partial class Config : RosMsg
    {
        public BoolParameter[] bools
        {
            get;
            set;
        }

        public IntParameter[] ints
        {
            get;
            set;
        }

        public StrParameter[] strs
        {
            get;
            set;
        }

        public DoubleParameter[] doubles
        {
            get;
            set;
        }

        public GroupState[] groups
        {
            get;
            set;
        }

        public Config(): base()
        {
        }

        public Config(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(bools.Length); for  ( int  i  =  0 ;  i < bools . Length ;  i ++ ) bools [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(ints.Length); for  ( int  i  =  0 ;  i < ints . Length ;  i ++ ) ints [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(strs.Length); for  ( int  i  =  0 ;  i < strs . Length ;  i ++ ) strs [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(doubles.Length); for  ( int  i  =  0 ;  i < doubles . Length ;  i ++ ) doubles [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(groups.Length); for  ( int  i  =  0 ;  i < groups . Length ;  i ++ ) groups [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            bools = new BoolParameter[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < bools . Length ;  i ++ ) bools [ i ]  =  new  BoolParameter ( binaryReader ) ; 
            ints = new IntParameter[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < ints . Length ;  i ++ ) ints [ i ]  =  new  IntParameter ( binaryReader ) ; 
            strs = new StrParameter[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < strs . Length ;  i ++ ) strs [ i ]  =  new  StrParameter ( binaryReader ) ; 
            doubles = new DoubleParameter[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < doubles . Length ;  i ++ ) doubles [ i ]  =  new  DoubleParameter ( binaryReader ) ; 
            groups = new GroupState[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < groups . Length ;  i ++ ) groups [ i ]  =  new  GroupState ( binaryReader ) ; 
        }
    }
}