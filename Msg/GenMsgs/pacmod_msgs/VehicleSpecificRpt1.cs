namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/VehicleSpecificRpt1", "e61481747bb1386c6b9f8ef5c5adad62", @"Header header

uint8 shift_pos_1
uint8 shift_pos_2
")]
    public partial class VehicleSpecificRpt1 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Byte shift_pos_1
        {
            get;
            set;
        }

        public System.Byte shift_pos_2
        {
            get;
            set;
        }

        public VehicleSpecificRpt1(): base()
        {
        }

        public VehicleSpecificRpt1(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(shift_pos_1);
            binaryWriter.Write(shift_pos_2);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            shift_pos_1 = binaryReader.ReadByte();
            shift_pos_2 = binaryReader.ReadByte();
        }
    }
}