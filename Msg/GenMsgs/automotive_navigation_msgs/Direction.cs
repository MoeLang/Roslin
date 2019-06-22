namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/Direction", "be51359feea72effac0609673308da52", "# Simple vehicle direction\nHeader header\n\nint8 BACKWARD=-1\nint8 ZERO=0\nint8 FORWARD=1\n\nint8 direction\n")]
    public partial class Direction : RosMsg
    {
        public System.SByte BACKWARD => -1;
        public System.SByte ZERO => 0;
        public System.SByte FORWARD => 1;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.SByte direction
        {
            get;
            set;
        }

        public Direction(): base()
        {
        }

        public Direction(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(direction);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            direction = binaryReader.ReadSByte();
        }
    }
}