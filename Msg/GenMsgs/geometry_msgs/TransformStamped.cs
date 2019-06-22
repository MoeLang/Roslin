namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/TransformStamped", "b5764a33bfeb3588febc2682852579b0", "# This expresses a transform from coordinate frame header.frame_id\n# to the coordinate frame child_frame_id\n#\n# This message is mostly used by the \n# <a href=\"http://wiki.ros.org/tf\">tf</a> package. \n# See its documentation for more information.\n\nHeader header\nstring child_frame_id # the frame id of the child frame\nTransform transform\n")]
    public partial class TransformStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String child_frame_id
        {
            get;
            set;
        }

        public Transform transform
        {
            get;
            set;
        }

        public TransformStamped(): base()
        {
        }

        public TransformStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(child_frame_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( child_frame_id ) ) ; 
            transform.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            child_frame_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            transform = new Transform(binaryReader);
        }
    }
}