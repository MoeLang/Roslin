namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/InteriorLightsRpt", "edb83c466d141d95fcc059ad99141e5e", "Header header\n\nbool front_dome_lights_on\nbool front_dome_lights_on_is_valid\nbool rear_dome_lights_on\nbool rear_dome_lights_on_is_valid\nbool mood_lights_on\nbool mood_lights_on_is_valid\nuint8 dim_level\nbool dim_level_is_valid\n\nuint8 DIM_LEVEL_MIN = 0\nuint8 DIM_LEVEL_1 = 1\nuint8 DIM_LEVEL_2 = 2\nuint8 DIM_LEVEL_3 = 3\nuint8 DIM_LEVEL_4 = 4\nuint8 DIM_LEVEL_5 = 5\nuint8 DIM_LEVEL_6 = 6\nuint8 DIM_LEVEL_7 = 7\nuint8 DIM_LEVEL_8 = 8\nuint8 DIM_LEVEL_9 = 9\nuint8 DIM_LEVEL_10 = 10\nuint8 DIM_LEVEL_11 = 11\nuint8 DIM_LEVEL_MAX = 12\n")]
    public partial class InteriorLightsRpt : RosMsg
    {
        public System.Byte DIM_LEVEL_MIN => 0;
        public System.Byte DIM_LEVEL_1 => 1;
        public System.Byte DIM_LEVEL_2 => 2;
        public System.Byte DIM_LEVEL_3 => 3;
        public System.Byte DIM_LEVEL_4 => 4;
        public System.Byte DIM_LEVEL_5 => 5;
        public System.Byte DIM_LEVEL_6 => 6;
        public System.Byte DIM_LEVEL_7 => 7;
        public System.Byte DIM_LEVEL_8 => 8;
        public System.Byte DIM_LEVEL_9 => 9;
        public System.Byte DIM_LEVEL_10 => 10;
        public System.Byte DIM_LEVEL_11 => 11;
        public System.Byte DIM_LEVEL_MAX => 12;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean front_dome_lights_on
        {
            get;
            set;
        }

        public System.Boolean front_dome_lights_on_is_valid
        {
            get;
            set;
        }

        public System.Boolean rear_dome_lights_on
        {
            get;
            set;
        }

        public System.Boolean rear_dome_lights_on_is_valid
        {
            get;
            set;
        }

        public System.Boolean mood_lights_on
        {
            get;
            set;
        }

        public System.Boolean mood_lights_on_is_valid
        {
            get;
            set;
        }

        public System.Byte dim_level
        {
            get;
            set;
        }

        public System.Boolean dim_level_is_valid
        {
            get;
            set;
        }

        public InteriorLightsRpt(): base()
        {
        }

        public InteriorLightsRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(front_dome_lights_on);
            binaryWriter.Write(front_dome_lights_on_is_valid);
            binaryWriter.Write(rear_dome_lights_on);
            binaryWriter.Write(rear_dome_lights_on_is_valid);
            binaryWriter.Write(mood_lights_on);
            binaryWriter.Write(mood_lights_on_is_valid);
            binaryWriter.Write(dim_level);
            binaryWriter.Write(dim_level_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            front_dome_lights_on = binaryReader.ReadBoolean();
            front_dome_lights_on_is_valid = binaryReader.ReadBoolean();
            rear_dome_lights_on = binaryReader.ReadBoolean();
            rear_dome_lights_on_is_valid = binaryReader.ReadBoolean();
            mood_lights_on = binaryReader.ReadBoolean();
            mood_lights_on_is_valid = binaryReader.ReadBoolean();
            dim_level = binaryReader.ReadByte();
            dim_level_is_valid = binaryReader.ReadBoolean();
        }
    }
}