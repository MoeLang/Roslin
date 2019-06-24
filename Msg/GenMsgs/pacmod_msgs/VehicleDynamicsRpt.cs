namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/VehicleDynamicsRpt", "76c5ee0fb5b1065da372a973e2ffdd31", @"Header header

float64 brake_torque       # Measured brake torque
uint8 g_forces             # Measured g forces

")]
    public partial class VehicleDynamicsRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double brake_torque
        {
            get;
            set;
        }

        public System.Byte g_forces
        {
            get;
            set;
        }

        public VehicleDynamicsRpt(): base()
        {
        }

        public VehicleDynamicsRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(brake_torque);
            binaryWriter.Write(g_forces);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            brake_torque = binaryReader.ReadDouble();
            g_forces = binaryReader.ReadByte();
        }
    }
}