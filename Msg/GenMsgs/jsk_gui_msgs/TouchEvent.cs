namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/TouchEvent", "f074642ed1ad51ea5afc186cab8aaca1", "byte DOWN=0\nbyte UP=1\nbyte MOVE=2\n\nbyte state\nfloat32 x\nfloat32 y\nfloat32 w\nfloat32 h")]
    public partial class TouchEvent : RosMsg
    {
        public System.Byte DOWN => 0;
        public System.Byte UP => 1;
        public System.Byte MOVE => 2;
        public System.Byte state
        {
            get;
            set;
        }

        public System.Single x
        {
            get;
            set;
        }

        public System.Single y
        {
            get;
            set;
        }

        public System.Single w
        {
            get;
            set;
        }

        public System.Single h
        {
            get;
            set;
        }

        public TouchEvent(): base()
        {
        }

        public TouchEvent(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(state);
            binaryWriter.Write(x);
            binaryWriter.Write(y);
            binaryWriter.Write(w);
            binaryWriter.Write(h);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            state = binaryReader.ReadByte();
            x = binaryReader.ReadSingle();
            y = binaryReader.ReadSingle();
            w = binaryReader.ReadSingle();
            h = binaryReader.ReadSingle();
        }
    }
}