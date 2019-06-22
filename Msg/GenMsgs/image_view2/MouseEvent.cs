namespace Roslin.Msg.image_view2
{
    [MsgInfo("image_view2/MouseEvent", "7ffa73624c1be385169a9e6e23460224", "Header header\n\n# event type\nint32 KEY_PRESSED=1\nint32 MOUSE_LEFT_UP=2\nint32 MOUSE_LEFT_DOWN=3\nint32 MOUSE_MOVE=4\nint32 MOUSE_RIGHT_DOWN=5\nint32 type\n\nint32 key\n\n# location of mouse\nint32 x\nint32 y\n\n# size of image\nint32 width\nint32 height")]
    public partial class MouseEvent : RosMsg
    {
        public System.Int32 KEY_PRESSED => 1;
        public System.Int32 MOUSE_LEFT_UP => 2;
        public System.Int32 MOUSE_LEFT_DOWN => 3;
        public System.Int32 MOUSE_MOVE => 4;
        public System.Int32 MOUSE_RIGHT_DOWN => 5;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Int32 type
        {
            get;
            set;
        }

        public System.Int32 key
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

        public MouseEvent(): base()
        {
        }

        public MouseEvent(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(type);
            binaryWriter.Write(key);
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(width);
            binaryWriter.Write(height);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            type = binaryReader.ReadInt32();
            key = binaryReader.ReadInt32();
            x = binaryReader.ReadInt32();
            y = binaryReader.ReadInt32();
            width = binaryReader.ReadInt32();
            height = binaryReader.ReadInt32();
        }
    }
}