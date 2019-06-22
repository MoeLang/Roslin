namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/VehicleSpeedRpt", "33c26f1bbea2c9136f0821ddc90cd049", "Header header\n\nfloat64 vehicle_speed         # Measured vehicle speed\nbool vehicle_speed_valid      # Flag indicating if measured vehicle speed is valid\nuint8[2] vehicle_speed_raw    # Raw bytes from vehicle CAN bus                \n\n")]
    public partial class VehicleSpeedRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double vehicle_speed
        {
            get;
            set;
        }

        public System.Boolean vehicle_speed_valid
        {
            get;
            set;
        }

        public System.Byte[] vehicle_speed_raw
        {
            get;
            set;
        }

        public VehicleSpeedRpt(): base()
        {
        }

        public VehicleSpeedRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(vehicle_speed);
            binaryWriter.Write(vehicle_speed_valid);
            binaryWriter.Write(vehicle_speed_raw);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            vehicle_speed = binaryReader.ReadDouble();
            vehicle_speed_valid = binaryReader.ReadBoolean();
            vehicle_speed_raw = new System.Byte[2]; vehicle_speed_raw  =  binaryReader . ReadBytes ( vehicle_speed_raw . Length ) ; 
        }
    }
}