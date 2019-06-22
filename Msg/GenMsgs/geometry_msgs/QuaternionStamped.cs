namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/QuaternionStamped", "e57f1e547e0e1fd13504588ffc8334e2", "# This represents an orientation with reference coordinate frame and timestamp.\n\nHeader header\nQuaternion quaternion\n")]
    public partial class QuaternionStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Quaternion quaternion
        {
            get;
            set;
        }

        public QuaternionStamped(): base()
        {
        }

        public QuaternionStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            quaternion.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            quaternion = new Quaternion(binaryReader);
        }
    }
}