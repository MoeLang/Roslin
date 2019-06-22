namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/DeviceSensor", "d3861ba768b988b4c249337d4dc6552d", "float64 temperature\nfloat64 relative_humidity\nfloat64 light\nfloat64 pressure\nfloat64 proximity\n\n\n\n")]
    public partial class DeviceSensor : RosMsg
    {
        public System.Double temperature
        {
            get;
            set;
        }

        public System.Double relative_humidity
        {
            get;
            set;
        }

        public System.Double light
        {
            get;
            set;
        }

        public System.Double pressure
        {
            get;
            set;
        }

        public System.Double proximity
        {
            get;
            set;
        }

        public DeviceSensor(): base()
        {
        }

        public DeviceSensor(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(temperature);
            binaryWriter.Write(relative_humidity);
            binaryWriter.Write(light);
            binaryWriter.Write(pressure);
            binaryWriter.Write(proximity);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            temperature = binaryReader.ReadDouble();
            relative_humidity = binaryReader.ReadDouble();
            light = binaryReader.ReadDouble();
            pressure = binaryReader.ReadDouble();
            proximity = binaryReader.ReadDouble();
        }
    }
}