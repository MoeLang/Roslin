namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/Illuminance", "8cf5febb0952fca9d650c3d11a81a188", " # Single photometric illuminance measurement.  Light should be assumed to be\n # measured along the sensor's x-axis (the area of detection is the y-z plane).\n # The illuminance should have a 0 or positive value and be received with\n # the sensor's +X axis pointing toward the light source.\n\n # Photometric illuminance is the measure of the human eye's sensitivity of the\n # intensity of light encountering or passing through a surface.\n\n # All other Photometric and Radiometric measurements should\n # not use this message.\n # This message cannot represent:\n # Luminous intensity (candela/light source output)\n # Luminance (nits/light output per area)\n # Irradiance (watt/area), etc.\n\n Header header           # timestamp is the time the illuminance was measured\n                         # frame_id is the location and direction of the reading\n\n float64 illuminance     # Measurement of the Photometric Illuminance in Lux.\n\n float64 variance        # 0 is interpreted as variance unknown")]
    public partial class Illuminance : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double illuminance
        {
            get;
            set;
        }

        public System.Double variance
        {
            get;
            set;
        }

        public Illuminance(): base()
        {
        }

        public Illuminance(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(illuminance);
            binaryWriter.Write(variance);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            illuminance = binaryReader.ReadDouble();
            variance = binaryReader.ReadDouble();
        }
    }
}