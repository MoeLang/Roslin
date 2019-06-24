namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Header", "2176decaecbce78abc3b96ef049fabed", @"# Standard metadata for higher-level stamped data types.
# This is generally used to communicate timestamped data 
# in a particular coordinate frame.
# 
# sequence ID: consecutively increasing ID 
uint32 seq
#Two-integer timestamp that is expressed as:
# * stamp.sec: seconds (stamp_secs) since epoch (in Python the variable is called 'secs')
# * stamp.nsec: nanoseconds since stamp_secs (in Python the variable is called 'nsecs')
# time-handling sugar is provided by the client library
time stamp
#Frame this data is associated with
string frame_id
")]
    public partial class Header : RosMsg
    {
        public System.UInt32 seq
        {
            get;
            set;
        }

        public System.DateTime stamp
        {
            get;
            set;
        }

        public System.String frame_id
        {
            get;
            set;
        }

        public Header(): base()
        {
        }

        public Header(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(seq);
            binaryWriter.Write(stamp);
            binaryWriter.Write(frame_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( frame_id ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            seq = binaryReader.ReadUInt32();
            stamp = binaryReader.ReadDateTime();
            frame_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}