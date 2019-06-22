namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/Action", "d81dc8475ff89ce7097d2e73ebfc2591", "byte RARMID=0\nbyte LARMID=1\n\n# task: push, pick, open, slide, MoveNeck, MoveBase\nstring task_name\n\n# selection: button names\n# string selection_name\n\n# arm: :rarm, :lsrm\nint64 arm_id\n\n# state of touch: touch, pick, pinch, sweep\n# for debugging\nstring state\n# value of state\nfloat64 state_value\n\n# direction: up, down, left, right\nstring direction\n# value of direction, degree\nfloat64 direction_value\n\nint64 touch_x\nint64 touch_y\n\n# Example\n#  push: touches[0].x, touches[0].y, task_name, arm_id\n#  open: touches[0 1 2].x, touches[0 1 2].y, task_name, arm_id\n#  slide: touches[0 1 2].x, touches[0 1 2].y, task_name, arm_id\n#  move_neck: task_name, direction, direction_value\n#  move_base: task_name, direction, direction_value")]
    public partial class Action : RosMsg
    {
        public System.Byte RARMID => 0;
        public System.Byte LARMID => 1;
        public System.String task_name
        {
            get;
            set;
        }

        public System.Int64 arm_id
        {
            get;
            set;
        }

        public System.String state
        {
            get;
            set;
        }

        public System.Double state_value
        {
            get;
            set;
        }

        public System.String direction
        {
            get;
            set;
        }

        public System.Double direction_value
        {
            get;
            set;
        }

        public System.Int64 touch_x
        {
            get;
            set;
        }

        public System.Int64 touch_y
        {
            get;
            set;
        }

        public Action(): base()
        {
        }

        public Action(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(task_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( task_name ) ) ; 
            binaryWriter.Write(arm_id);
            binaryWriter.Write(state.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( state ) ) ; 
            binaryWriter.Write(state_value);
            binaryWriter.Write(direction.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( direction ) ) ; 
            binaryWriter.Write(direction_value);
            binaryWriter.Write(touch_x);
            binaryWriter.Write(touch_y);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            task_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            arm_id = binaryReader.ReadInt64();
            state = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            state_value = binaryReader.ReadDouble();
            direction = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            direction_value = binaryReader.ReadDouble();
            touch_x = binaryReader.ReadInt64();
            touch_y = binaryReader.ReadInt64();
        }
    }
}