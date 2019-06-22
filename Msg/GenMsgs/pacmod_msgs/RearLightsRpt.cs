namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/RearLightsRpt", "5adfcaa5d9423963ef8c117009d03bbe", "Header header\n\nbool brake_lights_on\nbool brake_lights_on_is_valid\nbool reverse_lights_on\nbool reverse_lights_on_is_valid\n")]
    public partial class RearLightsRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean brake_lights_on
        {
            get;
            set;
        }

        public System.Boolean brake_lights_on_is_valid
        {
            get;
            set;
        }

        public System.Boolean reverse_lights_on
        {
            get;
            set;
        }

        public System.Boolean reverse_lights_on_is_valid
        {
            get;
            set;
        }

        public RearLightsRpt(): base()
        {
        }

        public RearLightsRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(brake_lights_on);
            binaryWriter.Write(brake_lights_on_is_valid);
            binaryWriter.Write(reverse_lights_on);
            binaryWriter.Write(reverse_lights_on_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            brake_lights_on = binaryReader.ReadBoolean();
            brake_lights_on_is_valid = binaryReader.ReadBoolean();
            reverse_lights_on = binaryReader.ReadBoolean();
            reverse_lights_on_is_valid = binaryReader.ReadBoolean();
        }
    }
}