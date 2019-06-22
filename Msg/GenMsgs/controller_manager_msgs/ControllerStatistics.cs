namespace Roslin.Msg.controller_manager_msgs
{
    [MsgInfo("controller_manager_msgs/ControllerStatistics", "697780c372c8d8597a1436d0e2ad3ba8", "# This message contains the state of one realtime controller\n# that was spawned in the controller manager\n\n# the name of the controller\nstring name\n\n# the type of the controller\nstring type\n\n# the time at which these controller statistics were measured\ntime timestamp\n\n# bool that indicates if the controller is currently\n# in a running or a stopped state\nbool running\n\n# the maximum time the update loop of the controller ever needed to complete\nduration max_time\n\n# the average time the update loop of the controller needs to complete.\n# the average is computed in a sliding time window.\nduration mean_time\n\n# the variance on the time the update loop of the controller needs to complete.\n# the variance applies to a sliding time window.\nduration variance_time\n\n# the number of times this controller broke the realtime loop\nint32 num_control_loop_overruns\n\n# the timestamp of the last time this controller broke the realtime loop\ntime time_last_control_loop_overrun")]
    public partial class ControllerStatistics : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.String type
        {
            get;
            set;
        }

        public System.DateTime timestamp
        {
            get;
            set;
        }

        public System.Boolean running
        {
            get;
            set;
        }

        public System.TimeSpan max_time
        {
            get;
            set;
        }

        public System.TimeSpan mean_time
        {
            get;
            set;
        }

        public System.TimeSpan variance_time
        {
            get;
            set;
        }

        public System.Int32 num_control_loop_overruns
        {
            get;
            set;
        }

        public System.DateTime time_last_control_loop_overrun
        {
            get;
            set;
        }

        public ControllerStatistics(): base()
        {
        }

        public ControllerStatistics(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(type.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( type ) ) ; 
            binaryWriter.Write(timestamp);
            binaryWriter.Write(running);
            binaryWriter.Write(max_time);
            binaryWriter.Write(mean_time);
            binaryWriter.Write(variance_time);
            binaryWriter.Write(num_control_loop_overruns);
            binaryWriter.Write(time_last_control_loop_overrun);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            type = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            timestamp = binaryReader.ReadDateTime();
            running = binaryReader.ReadBoolean();
            max_time = binaryReader.ReadTimeSpan();
            mean_time = binaryReader.ReadTimeSpan();
            variance_time = binaryReader.ReadTimeSpan();
            num_control_loop_overruns = binaryReader.ReadInt32();
            time_last_control_loop_overrun = binaryReader.ReadDateTime();
        }
    }
}