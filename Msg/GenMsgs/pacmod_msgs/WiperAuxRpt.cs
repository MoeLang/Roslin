namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/WiperAuxRpt", "663ea0989c9628effd21f08690caa7d1", "Header header\n\nbool front_wiping\nbool front_wiping_is_valid\nbool front_spraying\nbool front_spraying_is_valid\nbool rear_wiping\nbool rear_wiping_is_valid\nbool rear_spraying\nbool rear_spraying_is_valid\nbool spray_near_empty\nbool spray_near_empty_is_valid\nbool spray_empty\nbool spray_empty_is_valid\n")]
    public partial class WiperAuxRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean front_wiping
        {
            get;
            set;
        }

        public System.Boolean front_wiping_is_valid
        {
            get;
            set;
        }

        public System.Boolean front_spraying
        {
            get;
            set;
        }

        public System.Boolean front_spraying_is_valid
        {
            get;
            set;
        }

        public System.Boolean rear_wiping
        {
            get;
            set;
        }

        public System.Boolean rear_wiping_is_valid
        {
            get;
            set;
        }

        public System.Boolean rear_spraying
        {
            get;
            set;
        }

        public System.Boolean rear_spraying_is_valid
        {
            get;
            set;
        }

        public System.Boolean spray_near_empty
        {
            get;
            set;
        }

        public System.Boolean spray_near_empty_is_valid
        {
            get;
            set;
        }

        public System.Boolean spray_empty
        {
            get;
            set;
        }

        public System.Boolean spray_empty_is_valid
        {
            get;
            set;
        }

        public WiperAuxRpt(): base()
        {
        }

        public WiperAuxRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(front_wiping);
            binaryWriter.Write(front_wiping_is_valid);
            binaryWriter.Write(front_spraying);
            binaryWriter.Write(front_spraying_is_valid);
            binaryWriter.Write(rear_wiping);
            binaryWriter.Write(rear_wiping_is_valid);
            binaryWriter.Write(rear_spraying);
            binaryWriter.Write(rear_spraying_is_valid);
            binaryWriter.Write(spray_near_empty);
            binaryWriter.Write(spray_near_empty_is_valid);
            binaryWriter.Write(spray_empty);
            binaryWriter.Write(spray_empty_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            front_wiping = binaryReader.ReadBoolean();
            front_wiping_is_valid = binaryReader.ReadBoolean();
            front_spraying = binaryReader.ReadBoolean();
            front_spraying_is_valid = binaryReader.ReadBoolean();
            rear_wiping = binaryReader.ReadBoolean();
            rear_wiping_is_valid = binaryReader.ReadBoolean();
            rear_spraying = binaryReader.ReadBoolean();
            rear_spraying_is_valid = binaryReader.ReadBoolean();
            spray_near_empty = binaryReader.ReadBoolean();
            spray_near_empty_is_valid = binaryReader.ReadBoolean();
            spray_empty = binaryReader.ReadBoolean();
            spray_empty_is_valid = binaryReader.ReadBoolean();
        }
    }
}