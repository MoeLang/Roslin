namespace Roslin.Msg.rosgraph_msgs
{
    [MsgInfo("rosgraph_msgs/TopicStatistics", "10152ed868c5097a5e2e4a89d7daa710", "# name of the topic\nstring topic\n\n# node id of the publisher\nstring node_pub\n\n# node id of the subscriber\nstring node_sub\n\n# the statistics apply to this time window\ntime window_start\ntime window_stop\n\n# number of messages delivered during the window\nint32 delivered_msgs\n# numbers of messages dropped during the window\nint32 dropped_msgs\n\n# traffic during the window, in bytes\nint32 traffic\n\n# mean/stddev/max period between two messages\nduration period_mean\nduration period_stddev\nduration period_max\n\n# mean/stddev/max age of the message based on the\n# timestamp in the message header. In case the\n# message does not have a header, it will be 0.\nduration stamp_age_mean\nduration stamp_age_stddev\nduration stamp_age_max\n")]
    public partial class TopicStatistics : RosMsg
    {
        public System.String topic
        {
            get;
            set;
        }

        public System.String node_pub
        {
            get;
            set;
        }

        public System.String node_sub
        {
            get;
            set;
        }

        public System.DateTime window_start
        {
            get;
            set;
        }

        public System.DateTime window_stop
        {
            get;
            set;
        }

        public System.Int32 delivered_msgs
        {
            get;
            set;
        }

        public System.Int32 dropped_msgs
        {
            get;
            set;
        }

        public System.Int32 traffic
        {
            get;
            set;
        }

        public System.TimeSpan period_mean
        {
            get;
            set;
        }

        public System.TimeSpan period_stddev
        {
            get;
            set;
        }

        public System.TimeSpan period_max
        {
            get;
            set;
        }

        public System.TimeSpan stamp_age_mean
        {
            get;
            set;
        }

        public System.TimeSpan stamp_age_stddev
        {
            get;
            set;
        }

        public System.TimeSpan stamp_age_max
        {
            get;
            set;
        }

        public TopicStatistics(): base()
        {
        }

        public TopicStatistics(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(topic.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( topic ) ) ; 
            binaryWriter.Write(node_pub.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( node_pub ) ) ; 
            binaryWriter.Write(node_sub.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( node_sub ) ) ; 
            binaryWriter.Write(window_start);
            binaryWriter.Write(window_stop);
            binaryWriter.Write(delivered_msgs);
            binaryWriter.Write(dropped_msgs);
            binaryWriter.Write(traffic);
            binaryWriter.Write(period_mean);
            binaryWriter.Write(period_stddev);
            binaryWriter.Write(period_max);
            binaryWriter.Write(stamp_age_mean);
            binaryWriter.Write(stamp_age_stddev);
            binaryWriter.Write(stamp_age_max);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            topic = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            node_pub = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            node_sub = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            window_start = binaryReader.ReadDateTime();
            window_stop = binaryReader.ReadDateTime();
            delivered_msgs = binaryReader.ReadInt32();
            dropped_msgs = binaryReader.ReadInt32();
            traffic = binaryReader.ReadInt32();
            period_mean = binaryReader.ReadTimeSpan();
            period_stddev = binaryReader.ReadTimeSpan();
            period_max = binaryReader.ReadTimeSpan();
            stamp_age_mean = binaryReader.ReadTimeSpan();
            stamp_age_stddev = binaryReader.ReadTimeSpan();
            stamp_age_max = binaryReader.ReadTimeSpan();
        }
    }
}