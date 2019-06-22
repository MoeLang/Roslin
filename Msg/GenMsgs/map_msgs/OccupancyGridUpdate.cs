namespace Roslin.Msg.map_msgs
{
    [MsgInfo("map_msgs/OccupancyGridUpdate", "b295be292b335c34718bd939deebe1c9", "Header header\nint32 x\nint32 y\nuint32 width\nuint32 height\nint8[] data\n")]
    public partial class OccupancyGridUpdate : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Int32 x
        {
            get;
            set;
        }

        public System.Int32 y
        {
            get;
            set;
        }

        public System.UInt32 width
        {
            get;
            set;
        }

        public System.UInt32 height
        {
            get;
            set;
        }

        public System.SByte[] data
        {
            get;
            set;
        }

        public OccupancyGridUpdate(): base()
        {
        }

        public OccupancyGridUpdate(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(width);
            binaryWriter.Write(height);
            binaryWriter.Write(data.Length); for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) binaryWriter . Write ( data [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            x = binaryReader.ReadInt32();
            y = binaryReader.ReadInt32();
            width = binaryReader.ReadUInt32();
            height = binaryReader.ReadUInt32();
            data = new System.SByte[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  binaryReader . ReadSByte ( ) ; 
        }
    }
}