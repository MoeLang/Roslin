namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/RelativeHumidity", "8730015b05955b7e992ce29a2678d90f", " # Single reading from a relative humidity sensor.  Defines the ratio of partial\n # pressure of water vapor to the saturated vapor pressure at a temperature.\n\n Header header             # timestamp of the measurement\n                           # frame_id is the location of the humidity sensor\n\n float64 relative_humidity # Expression of the relative humidity\n                           # from 0.0 to 1.0.\n                           # 0.0 is no partial pressure of water vapor\n                           # 1.0 represents partial pressure of saturation\n\n float64 variance          # 0 is interpreted as variance unknown")]
    public partial class RelativeHumidity : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double relative_humidity
        {
            get;
            set;
        }

        public System.Double variance
        {
            get;
            set;
        }

        public RelativeHumidity(): base()
        {
        }

        public RelativeHumidity(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(relative_humidity);
            binaryWriter.Write(variance);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            relative_humidity = binaryReader.ReadDouble();
            variance = binaryReader.ReadDouble();
        }
    }
}