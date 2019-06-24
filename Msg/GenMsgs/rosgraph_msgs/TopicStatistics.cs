namespace Roslin.Msg.rosgraph_msgs
{
    [MsgInfo("rosgraph_msgs/TopicStatistics", "10152ed868c5097a5e2e4a89d7daa710", @"# name of the topic
string topic

# node id of the publisher
string node_pub

# node id of the subscriber
string node_sub

# the statistics apply to this time window
time window_start
time window_stop

# number of messages delivered during the window
int32 delivered_msgs
# numbers of messages dropped during the window
int32 dropped_msgs

# traffic during the window, in bytes
int32 traffic

# mean/stddev/max period between two messages
duration period_mean
duration period_stddev
duration period_max

# mean/stddev/max age of the message based on the
# timestamp in the message header. In case the
# message does not have a header, it will be 0.
duration stamp_age_mean
duration stamp_age_stddev
duration stamp_age_max
")]
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