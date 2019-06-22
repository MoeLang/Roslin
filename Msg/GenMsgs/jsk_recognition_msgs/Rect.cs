namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Rect", "4425f1067abc7ec2e487d28194eccff4", "int32 x\nint32 y\nint32 width\nint32 height\n")]
    public partial class Rect : RosMsg
    {
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

        public System.Int32 width
        {
            get;
            set;
        }

        public System.Int32 height
        {
            get;
            set;
        }

        public Rect(): base()
        {
        }

        public Rect(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(width);
            binaryWriter.Write(height);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            x = binaryReader.ReadInt32();
            y = binaryReader.ReadInt32();
            width = binaryReader.ReadInt32();
            height = binaryReader.ReadInt32();
        }
    }
}