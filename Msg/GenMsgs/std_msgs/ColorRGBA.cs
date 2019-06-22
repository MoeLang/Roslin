namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/ColorRGBA", "a29a96539573343b1310c73607334b00", "float32 r\nfloat32 g\nfloat32 b\nfloat32 a\n")]
    public partial class ColorRGBA : RosMsg
    {
        public System.Single r
        {
            get;
            set;
        }

        public System.Single g
        {
            get;
            set;
        }

        public System.Single b
        {
            get;
            set;
        }

        public System.Single a
        {
            get;
            set;
        }

        public ColorRGBA(): base()
        {
        }

        public ColorRGBA(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(r);
            binaryWriter.Write(g);
            binaryWriter.Write(b);
            binaryWriter.Write(a);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            r = binaryReader.ReadSingle();
            g = binaryReader.ReadSingle();
            b = binaryReader.ReadSingle();
            a = binaryReader.ReadSingle();
        }
    }
}