namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/TurnAuxRpt", "c04dad80913279be4de094443dc50dca", "Header header\n\nbool driver_blinker_bulb_on\nbool driver_blinker_bulb_on_is_valid\nbool passenger_blinker_bulb_on\nbool passenger_blinker_bulb_on_is_valid\n")]
    public partial class TurnAuxRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean driver_blinker_bulb_on
        {
            get;
            set;
        }

        public System.Boolean driver_blinker_bulb_on_is_valid
        {
            get;
            set;
        }

        public System.Boolean passenger_blinker_bulb_on
        {
            get;
            set;
        }

        public System.Boolean passenger_blinker_bulb_on_is_valid
        {
            get;
            set;
        }

        public TurnAuxRpt(): base()
        {
        }

        public TurnAuxRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(driver_blinker_bulb_on);
            binaryWriter.Write(driver_blinker_bulb_on_is_valid);
            binaryWriter.Write(passenger_blinker_bulb_on);
            binaryWriter.Write(passenger_blinker_bulb_on_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            driver_blinker_bulb_on = binaryReader.ReadBoolean();
            driver_blinker_bulb_on_is_valid = binaryReader.ReadBoolean();
            passenger_blinker_bulb_on = binaryReader.ReadBoolean();
            passenger_blinker_bulb_on_is_valid = binaryReader.ReadBoolean();
        }
    }
}