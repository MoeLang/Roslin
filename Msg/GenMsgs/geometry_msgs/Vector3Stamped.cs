namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Vector3Stamped", "7b324c7325e683bf02a9b14b01090ec7", "# This represents a Vector3 with reference coordinate frame and timestamp\nHeader header\nVector3 vector\n")]
    public partial class Vector3Stamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Vector3 vector
        {
            get;
            set;
        }

        public Vector3Stamped(): base()
        {
        }

        public Vector3Stamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            vector.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            vector = new Vector3(binaryReader);
        }
    }
}