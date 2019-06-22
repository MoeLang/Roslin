namespace Roslin.Msg.turtlesim
{
    [MsgInfo("turtlesim/Color", "353891e354491c51aabe32df673fb446", "uint8 r\nuint8 g\nuint8 b\n")]
    public partial class Color : RosMsg
    {
        public System.Byte r
        {
            get;
            set;
        }

        public System.Byte g
        {
            get;
            set;
        }

        public System.Byte b
        {
            get;
            set;
        }

        public Color(): base()
        {
        }

        public Color(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(r);
            binaryWriter.Write(g);
            binaryWriter.Write(b);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            r = binaryReader.ReadByte();
            g = binaryReader.ReadByte();
            b = binaryReader.ReadByte();
        }
    }
}