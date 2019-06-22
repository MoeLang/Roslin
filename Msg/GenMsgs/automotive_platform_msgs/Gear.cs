namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/Gear", "79b3cd667a7556f4bc4a66af7d189c96", "# Transmission Gear Value\n# Provides common definitions for commanded and reported gear\n\nuint8 NONE=0\nuint8 PARK=1\nuint8 REVERSE=2\nuint8 NEUTRAL=3\nuint8 DRIVE=4\nuint8 LOW=5\nuint8 gear\n\n")]
    public partial class Gear : RosMsg
    {
        public System.Byte NONE => 0;
        public System.Byte PARK => 1;
        public System.Byte REVERSE => 2;
        public System.Byte NEUTRAL => 3;
        public System.Byte DRIVE => 4;
        public System.Byte LOW => 5;
        public System.Byte gear
        {
            get;
            set;
        }

        public Gear(): base()
        {
        }

        public Gear(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(gear);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            gear = binaryReader.ReadByte();
        }
    }
}