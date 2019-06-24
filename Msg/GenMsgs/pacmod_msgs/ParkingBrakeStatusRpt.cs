namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/ParkingBrakeStatusRpt", "28531874ceb48a58d4faa42b130fc228", @"Header header

bool parking_brake_engaged
")]
    public partial class ParkingBrakeStatusRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean parking_brake_engaged
        {
            get;
            set;
        }

        public ParkingBrakeStatusRpt(): base()
        {
        }

        public ParkingBrakeStatusRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(parking_brake_engaged);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            parking_brake_engaged = binaryReader.ReadBoolean();
        }
    }
}