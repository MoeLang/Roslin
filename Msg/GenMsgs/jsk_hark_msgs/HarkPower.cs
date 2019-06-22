namespace Roslin.Msg.jsk_hark_msgs
{
    [MsgInfo("jsk_hark_msgs/HarkPower", "251c13d7a8be27144a2b24c6f53df705", "Header header\nint32  count\nint32  directions\nint32  data_bytes\nfloat32[] powers\n")]
    public partial class HarkPower : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Int32 count
        {
            get;
            set;
        }

        public System.Int32 directions
        {
            get;
            set;
        }

        public System.Int32 data_bytes
        {
            get;
            set;
        }

        public System.Single[] powers
        {
            get;
            set;
        }

        public HarkPower(): base()
        {
        }

        public HarkPower(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(count);
            binaryWriter.Write(directions);
            binaryWriter.Write(data_bytes);
            binaryWriter.Write(powers.Length); for  ( int  i  =  0 ;  i < powers . Length ;  i ++ ) binaryWriter . Write ( powers [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            count = binaryReader.ReadInt32();
            directions = binaryReader.ReadInt32();
            data_bytes = binaryReader.ReadInt32();
            powers = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < powers . Length ;  i ++ ) powers [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}