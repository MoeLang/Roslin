namespace Roslin.Msg.image_view2
{
    [MsgInfo("image_view2/MouseEvent", "7ffa73624c1be385169a9e6e23460224", @"Header header

# event type
int32 KEY_PRESSED=1
int32 MOUSE_LEFT_UP=2
int32 MOUSE_LEFT_DOWN=3
int32 MOUSE_MOVE=4
int32 MOUSE_RIGHT_DOWN=5
int32 type

int32 key

# location of mouse
int32 x
int32 y

# size of image
int32 width
int32 height")]
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