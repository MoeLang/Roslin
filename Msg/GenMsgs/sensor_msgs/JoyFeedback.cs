namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/JoyFeedback", "f4dcd73460360d98f36e55ee7f2e46f1", "# Declare of the type of feedback\nuint8 TYPE_LED    = 0\nuint8 TYPE_RUMBLE = 1\nuint8 TYPE_BUZZER = 2\n\nuint8 type\n\n# This will hold an id number for each type of each feedback.\n# Example, the first led would be id=0, the second would be id=1\nuint8 id\n\n# Intensity of the feedback, from 0.0 to 1.0, inclusive.  If device is\n# actually binary, driver should treat 0<=x<0.5 as off, 0.5<=x<=1 as on.\nfloat32 intensity\n\n")]
    public partial class JoyFeedback : RosMsg
    {
        public System.Byte TYPE_LED => 0;
        public System.Byte TYPE_RUMBLE => 1;
        public System.Byte TYPE_BUZZER => 2;
        public System.Byte type
        {
            get;
            set;
        }

        public System.Byte id
        {
            get;
            set;
        }

        public System.Single intensity
        {
            get;
            set;
        }

        public JoyFeedback(): base()
        {
        }

        public JoyFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(type);
            binaryWriter.Write(id);
            binaryWriter.Write(intensity);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            type = binaryReader.ReadByte();
            id = binaryReader.ReadByte();
            intensity = binaryReader.ReadSingle();
        }
    }
}