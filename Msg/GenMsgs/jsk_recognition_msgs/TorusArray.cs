namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/TorusArray", "81d0dbf46016b5714fa4ea9eca5485e0", "Header header\nTorus[] toruses\n")]
    public partial class TorusArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Torus[] toruses
        {
            get;
            set;
        }

        public TorusArray(): base()
        {
        }

        public TorusArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(toruses.Length); for  ( int  i  =  0 ;  i < toruses . Length ;  i ++ ) toruses [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            toruses = new Torus[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < toruses . Length ;  i ++ ) toruses [ i ]  =  new  Torus ( binaryReader ) ; 
        }
    }
}