namespace Roslin.Msg.turtle_actionlib
{
    [MsgInfo("turtle_actionlib/ShapeActionResult", "c8d13d5d140f1047a2e4d3bf5c045822", "# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======\n\nHeader header\nactionlib_msgs/GoalStatus status\nShapeResult result\n")]
    public partial class ShapeActionResult : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public actionlib_msgs.GoalStatus status
        {
            get;
            set;
        }

        public ShapeResult result
        {
            get;
            set;
        }

        public ShapeActionResult(): base()
        {
        }

        public ShapeActionResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            status.Serilize(binaryWriter);
            result.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            status = new actionlib_msgs.GoalStatus(binaryReader);
            result = new ShapeResult(binaryReader);
        }
    }
}