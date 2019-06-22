namespace Roslin.Msg.actionlib_msgs
{
    [MsgInfo("actionlib_msgs/GoalStatusArray", "8b2b82f13216d0a8ea88bd3af735e619", "# Stores the statuses for goals that are currently being tracked\n# by an action server\nHeader header\nGoalStatus[] status_list\n\n")]
    public partial class GoalStatusArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public GoalStatus[] status_list
        {
            get;
            set;
        }

        public GoalStatusArray(): base()
        {
        }

        public GoalStatusArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(status_list.Length); for  ( int  i  =  0 ;  i < status_list . Length ;  i ++ ) status_list [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            status_list = new GoalStatus[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < status_list . Length ;  i ++ ) status_list [ i ]  =  new  GoalStatus ( binaryReader ) ; 
        }
    }
}