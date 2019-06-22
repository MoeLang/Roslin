namespace Roslin.Msg.theora_image_transport
{
    [MsgInfo("theora_image_transport/Packet", "33ac4e14a7cff32e7e0d65f18bb410f3", "# ROS message adaptation of the ogg_packet struct from libogg,\n# see http://www.xiph.org/ogg/doc/libogg/ogg_packet.html.\n\nHeader header     # Original sensor_msgs/Image header\nuint8[] data      # Raw Theora packet data (combines packet and bytes fields from ogg_packet)\nint32 b_o_s       # Flag indicating whether this packet begins a logical bitstream\nint32 e_o_s       # Flag indicating whether this packet ends a bitstream\nint64 granulepos  # A number indicating the position of this packet in the decoded data\nint64 packetno    # Sequential number of this packet in the ogg bitstream\n")]
    public partial class Packet : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Byte[] data
        {
            get;
            set;
        }

        public System.Int32 b_o_s
        {
            get;
            set;
        }

        public System.Int32 e_o_s
        {
            get;
            set;
        }

        public System.Int64 granulepos
        {
            get;
            set;
        }

        public System.Int64 packetno
        {
            get;
            set;
        }

        public Packet(): base()
        {
        }

        public Packet(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(data.Length); binaryWriter . Write ( data ) ; 
            binaryWriter.Write(b_o_s);
            binaryWriter.Write(e_o_s);
            binaryWriter.Write(granulepos);
            binaryWriter.Write(packetno);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            data = new System.Byte[binaryReader.ReadInt32()]; data  =  binaryReader . ReadBytes ( data . Length ) ; 
            b_o_s = binaryReader.ReadInt32();
            e_o_s = binaryReader.ReadInt32();
            granulepos = binaryReader.ReadInt64();
            packetno = binaryReader.ReadInt64();
        }
    }
}