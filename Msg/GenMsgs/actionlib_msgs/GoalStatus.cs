namespace Roslin.Msg.actionlib_msgs
{
    [MsgInfo("actionlib_msgs/GoalStatus", "d388f9b87b3c471f784434d671988d4a", @"GoalID goal_id
uint8 status
uint8 PENDING         = 0   # The goal has yet to be processed by the action server
uint8 ACTIVE          = 1   # The goal is currently being processed by the action server
uint8 PREEMPTED       = 2   # The goal received a cancel request after it started executing
                            #   and has since completed its execution (Terminal State)
uint8 SUCCEEDED       = 3   # The goal was achieved successfully by the action server (Terminal State)
uint8 ABORTED         = 4   # The goal was aborted during execution by the action server due
                            #    to some failure (Terminal State)
uint8 REJECTED        = 5   # The goal was rejected by the action server without being processed,
                            #    because the goal was unattainable or invalid (Terminal State)
uint8 PREEMPTING      = 6   # The goal received a cancel request after it started executing
                            #    and has not yet completed execution
uint8 RECALLING       = 7   # The goal received a cancel request before it started executing,
                            #    but the action server has not yet confirmed that the goal is canceled
uint8 RECALLED        = 8   # The goal received a cancel request before it started executing
                            #    and was successfully cancelled (Terminal State)
uint8 LOST            = 9   # An action client can determine that a goal is LOST. This should not be
                            #    sent over the wire by an action server

#Allow for the user to associate a string with GoalStatus for debugging
string text

")]
    public partial class GoalStatus : RosMsg
    {
        public System.Byte PENDING => 0;
        public System.Byte ACTIVE => 1;
        public System.Byte PREEMPTED => 2;
        public System.Byte SUCCEEDED => 3;
        public System.Byte ABORTED => 4;
        public System.Byte REJECTED => 5;
        public System.Byte PREEMPTING => 6;
        public System.Byte RECALLING => 7;
        public System.Byte RECALLED => 8;
        public System.Byte LOST => 9;
        public GoalID goal_id
        {
            get;
            set;
        }

        public System.Byte status
        {
            get;
            set;
        }

        public System.String text
        {
            get;
            set;
        }

        public GoalStatus(): base()
        {
        }

        public GoalStatus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            goal_id.Serilize(binaryWriter);
            binaryWriter.Write(status);
            binaryWriter.Write(text.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( text ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            goal_id = new GoalID(binaryReader);
            status = binaryReader.ReadByte();
            text = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}