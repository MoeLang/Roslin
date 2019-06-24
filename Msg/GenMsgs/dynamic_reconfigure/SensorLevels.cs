namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/SensorLevels", "6322637bee96d5489db6e2127c47602c", @"# This message is deprecated, please use driver_base/SensorLevels instead.

byte RECONFIGURE_CLOSE = 3  # Parameters that need a sensor to be stopped completely when changed
byte RECONFIGURE_STOP = 1  # Parameters that need a sensor to stop streaming when changed
byte RECONFIGURE_RUNNING = 0 # Parameters that can be changed while a sensor is streaming
")]
    public partial class SensorLevels : RosMsg
    {
        public System.Byte RECONFIGURE_CLOSE => 3;
        public System.Byte RECONFIGURE_STOP => 1;
        public System.Byte RECONFIGURE_RUNNING => 0;
        public SensorLevels(): base()
        {
        }

        public SensorLevels(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
        }
    }
}