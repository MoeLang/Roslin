namespace Roslin.Msg.std_msgs
{
    [MsgInfo("std_msgs/Time", "cd7166c74c552c311fbcc2fe5a7bc289", "time data\n")]
    public partial class Time : RosMsg
    {
        public System.DateTime data
        {
            get;
            set;
        }

        public Time(): base()
        {
        }

        public Time(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = binaryReader.ReadDateTime();
        }
    }
}