namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/InteriorLightsRpt", "edb83c466d141d95fcc059ad99141e5e", @"Header header

bool front_dome_lights_on
bool front_dome_lights_on_is_valid
bool rear_dome_lights_on
bool rear_dome_lights_on_is_valid
bool mood_lights_on
bool mood_lights_on_is_valid
uint8 dim_level
bool dim_level_is_valid

uint8 DIM_LEVEL_MIN = 0
uint8 DIM_LEVEL_1 = 1
uint8 DIM_LEVEL_2 = 2
uint8 DIM_LEVEL_3 = 3
uint8 DIM_LEVEL_4 = 4
uint8 DIM_LEVEL_5 = 5
uint8 DIM_LEVEL_6 = 6
uint8 DIM_LEVEL_7 = 7
uint8 DIM_LEVEL_8 = 8
uint8 DIM_LEVEL_9 = 9
uint8 DIM_LEVEL_10 = 10
uint8 DIM_LEVEL_11 = 11
uint8 DIM_LEVEL_MAX = 12
")]
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