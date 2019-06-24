namespace Roslin.Msg.control_msgs
{
    [MsgInfo("control_msgs/SingleJointPositionFeedback", "8cee65610a3d08e0a1bded82f146f1fd", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
Header header
float64 position
float64 velocity
float64 error

")]
    public partial class SingleJointPositionFeedback : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double position
        {
            get;
            set;
        }

        public System.Double velocity
        {
            get;
            set;
        }

        public System.Double error
        {
            get;
            set;
        }

        public SingleJointPositionFeedback(): base()
        {
        }

        public SingleJointPositionFeedback(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(position);
            binaryWriter.Write(velocity);
            binaryWriter.Write(error);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            position = binaryReader.ReadDouble();
            velocity = binaryReader.ReadDouble();
            error = binaryReader.ReadDouble();
        }
    }
}