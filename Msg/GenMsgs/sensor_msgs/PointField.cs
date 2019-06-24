namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/PointField", "268eacb2962780ceac86cbd17e328150", @"# This message holds the description of one point entry in the
# PointCloud2 message format.
uint8 INT8    = 1
uint8 UINT8   = 2
uint8 INT16   = 3
uint8 UINT16  = 4
uint8 INT32   = 5
uint8 UINT32  = 6
uint8 FLOAT32 = 7
uint8 FLOAT64 = 8

string name      # Name of field
uint32 offset    # Offset from start of point struct
uint8  datatype  # Datatype enumeration, see above
uint32 count     # How many elements in the field
")]
    public partial class PointField : RosMsg
    {
        public System.Byte INT8 => 1;
        public System.Byte UINT8 => 2;
        public System.Byte INT16 => 3;
        public System.Byte UINT16 => 4;
        public System.Byte INT32 => 5;
        public System.Byte UINT32 => 6;
        public System.Byte FLOAT32 => 7;
        public System.Byte FLOAT64 => 8;
        public System.String name
        {
            get;
            set;
        }

        public System.UInt32 offset
        {
            get;
            set;
        }

        public System.Byte datatype
        {
            get;
            set;
        }

        public System.UInt32 count
        {
            get;
            set;
        }

        public PointField(): base()
        {
        }

        public PointField(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(offset);
            binaryWriter.Write(datatype);
            binaryWriter.Write(count);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            offset = binaryReader.ReadUInt32();
            datatype = binaryReader.ReadByte();
            count = binaryReader.ReadUInt32();
        }
    }
}