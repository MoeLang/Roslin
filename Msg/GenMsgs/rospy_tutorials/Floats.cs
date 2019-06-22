namespace Roslin.Msg.rospy_tutorials
{
    [MsgInfo("rospy_tutorials/Floats", "420cd38b6b071cd49f2970c3e2cee511", "float32[] data\n")]
    public partial class Floats : RosMsg
    {
        public System.Single[] data
        {
            get;
            set;
        }

        public Floats(): base()
        {
        }

        public Floats(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data.Length); for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) binaryWriter . Write ( data [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}