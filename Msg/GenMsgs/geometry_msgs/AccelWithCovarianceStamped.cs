namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/AccelWithCovarianceStamped", "96adb295225031ec8d57fb4251b0a886", @"# This represents an estimated accel with reference coordinate frame and timestamp.
Header header
AccelWithCovariance accel
")]
    public partial class AccelWithCovarianceStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public AccelWithCovariance accel
        {
            get;
            set;
        }

        public AccelWithCovarianceStamped(): base()
        {
        }

        public AccelWithCovarianceStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            accel.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            accel = new AccelWithCovariance(binaryReader);
        }
    }
}