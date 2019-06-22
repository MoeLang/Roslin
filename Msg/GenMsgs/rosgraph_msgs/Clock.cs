namespace Roslin.Msg.rosgraph_msgs
{
    [MsgInfo("rosgraph_msgs/Clock", "a9c97c1d230cfc112e270351a944ee47", "# roslib/Clock is used for publishing simulated time in ROS. \n# This message simply communicates the current time.\n# For more information, see http://www.ros.org/wiki/Clock\ntime clock\n")]
    public partial class Clock : RosMsg
    {
        public System.DateTime clock
        {
            get;
            set;
        }

        public Clock(): base()
        {
        }

        public Clock(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(clock);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            clock = binaryReader.ReadDateTime();
        }
    }
}