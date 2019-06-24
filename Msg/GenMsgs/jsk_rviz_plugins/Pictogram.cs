namespace Roslin.Msg.jsk_rviz_plugins
{
    [MsgInfo("jsk_rviz_plugins/Pictogram", "29667e5652a8cfdc9c87d2ed97aa7bbc", @"Header header
geometry_msgs/Pose pose
uint8 ADD=0
uint8 DELETE=1
uint8 ROTATE_Z=2
uint8 ROTATE_Y=3
uint8 ROTATE_X=4
uint8 JUMP=5
uint8 JUMP_ONCE=6
uint8 action

uint8 PICTOGRAM_MODE=0 
uint8 STRING_MODE=1

uint8 mode
string character
float64 size
float64 ttl
float64 speed
std_msgs/ColorRGBA color
")]
    public partial class Pictogram : RosMsg
    {
        public System.Byte ADD => 0;
        public System.Byte DELETE => 1;
        public System.Byte ROTATE_Z => 2;
        public System.Byte ROTATE_Y => 3;
        public System.Byte ROTATE_X => 4;
        public System.Byte JUMP => 5;
        public System.Byte JUMP_ONCE => 6;
        public System.Byte PICTOGRAM_MODE => 0;
        public System.Byte STRING_MODE => 1;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public System.Byte action
        {
            get;
            set;
        }

        public System.Byte mode
        {
            get;
            set;
        }

        public System.String character
        {
            get;
            set;
        }

        public System.Double size
        {
            get;
            set;
        }

        public System.Double ttl
        {
            get;
            set;
        }

        public System.Double speed
        {
            get;
            set;
        }

        public std_msgs.ColorRGBA color
        {
            get;
            set;
        }

        public Pictogram(): base()
        {
        }

        public Pictogram(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            pose.Serilize(binaryWriter);
            binaryWriter.Write(action);
            binaryWriter.Write(mode);
            binaryWriter.Write(character.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( character ) ) ; 
            binaryWriter.Write(size);
            binaryWriter.Write(ttl);
            binaryWriter.Write(speed);
            color.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            pose = new geometry_msgs.Pose(binaryReader);
            action = binaryReader.ReadByte();
            mode = binaryReader.ReadByte();
            character = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            size = binaryReader.ReadDouble();
            ttl = binaryReader.ReadDouble();
            speed = binaryReader.ReadDouble();
            color = new std_msgs.ColorRGBA(binaryReader);
        }
    }
}