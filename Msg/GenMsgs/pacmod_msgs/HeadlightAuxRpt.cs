namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/HeadlightAuxRpt", "512cf6494650979b84da331a515edaf9", "Header header\n\nbool headlights_on\nbool headlights_on_is_valid\nbool headlights_on_bright\nbool headlights_on_bright_is_valid\nbool fog_lights_on\nbool fog_lights_on_is_valid\nuint8 headlights_mode\nbool headlights_mode_is_valid\n\nuint8 HEADLIGHTS_OFF = 0\nuint8 HEADLIGHTS_PARKING = 1\nuint8 HEADLIGHTS_MANUAL = 2\nuint8 HEADLIGHTS_AUTO = 3\n")]
    public partial class HeadlightAuxRpt : RosMsg
    {
        public System.Byte HEADLIGHTS_OFF => 0;
        public System.Byte HEADLIGHTS_PARKING => 1;
        public System.Byte HEADLIGHTS_MANUAL => 2;
        public System.Byte HEADLIGHTS_AUTO => 3;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean headlights_on
        {
            get;
            set;
        }

        public System.Boolean headlights_on_is_valid
        {
            get;
            set;
        }

        public System.Boolean headlights_on_bright
        {
            get;
            set;
        }

        public System.Boolean headlights_on_bright_is_valid
        {
            get;
            set;
        }

        public System.Boolean fog_lights_on
        {
            get;
            set;
        }

        public System.Boolean fog_lights_on_is_valid
        {
            get;
            set;
        }

        public System.Byte headlights_mode
        {
            get;
            set;
        }

        public System.Boolean headlights_mode_is_valid
        {
            get;
            set;
        }

        public HeadlightAuxRpt(): base()
        {
        }

        public HeadlightAuxRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(headlights_on);
            binaryWriter.Write(headlights_on_is_valid);
            binaryWriter.Write(headlights_on_bright);
            binaryWriter.Write(headlights_on_bright_is_valid);
            binaryWriter.Write(fog_lights_on);
            binaryWriter.Write(fog_lights_on_is_valid);
            binaryWriter.Write(headlights_mode);
            binaryWriter.Write(headlights_mode_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            headlights_on = binaryReader.ReadBoolean();
            headlights_on_is_valid = binaryReader.ReadBoolean();
            headlights_on_bright = binaryReader.ReadBoolean();
            headlights_on_bright_is_valid = binaryReader.ReadBoolean();
            fog_lights_on = binaryReader.ReadBoolean();
            fog_lights_on_is_valid = binaryReader.ReadBoolean();
            headlights_mode = binaryReader.ReadByte();
            headlights_mode_is_valid = binaryReader.ReadBoolean();
        }
    }
}