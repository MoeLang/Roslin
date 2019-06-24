namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/FluidPressure", "804dc5cea1c5306d6a2eb80b9833befe", @" # Single pressure reading.  This message is appropriate for measuring the
 # pressure inside of a fluid (air, water, etc).  This also includes
 # atmospheric or barometric pressure.

 # This message is not appropriate for force/pressure contact sensors.

 Header header           # timestamp of the measurement
                         # frame_id is the location of the pressure sensor

 float64 fluid_pressure  # Absolute pressure reading in Pascals.

 float64 variance        # 0 is interpreted as variance unknown")]
    public partial class FluidPressure : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double fluid_pressure
        {
            get;
            set;
        }

        public System.Double variance
        {
            get;
            set;
        }

        public FluidPressure(): base()
        {
        }

        public FluidPressure(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(fluid_pressure);
            binaryWriter.Write(variance);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            fluid_pressure = binaryReader.ReadDouble();
            variance = binaryReader.ReadDouble();
        }
    }
}