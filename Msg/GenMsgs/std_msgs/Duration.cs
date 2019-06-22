namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Duration", "3e286caf4241d664e55f3ad380e2ae46", "duration data\n")]
    public partial class Duration : RosMsg
    {
        public System.TimeSpan data
        {
            get;
            set;
        }

        public Duration(): base()
        {
        }

        public Duration(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadTimeSpan();
        }
    }
}