namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/Temperature", "ff71b307acdbe7c871a5a6d7ed359100", " # Single temperature reading.\n\n Header header           # timestamp is the time the temperature was measured\n                         # frame_id is the location of the temperature reading\n\n float64 temperature     # Measurement of the Temperature in Degrees Celsius\n\n float64 variance        # 0 is interpreted as variance unknown")]
    public partial class Temperature : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double temperature
        {
            get;
            set;
        }

        public System.Double variance
        {
            get;
            set;
        }

        public Temperature(): base()
        {
        }

        public Temperature(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(temperature);
            binaryWriter.Write(variance);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            temperature = binaryReader.ReadDouble();
            variance = binaryReader.ReadDouble();
        }
    }
}