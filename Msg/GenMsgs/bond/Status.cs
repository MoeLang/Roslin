namespace Roslin.Msg.bond
{
    [MsgInfo("bond/Status", "eacc84bf5d65b6777d4c50f463dfb9c8", "Header header\nstring id  # ID of the bond\nstring instance_id  # Unique ID for an individual in a bond\nbool active\n\n# Including the timeouts for the bond makes it easier to debug mis-matches\n# between the two sides.\nfloat32 heartbeat_timeout\nfloat32 heartbeat_period")]
    public partial class Status : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String id
        {
            get;
            set;
        }

        public System.String instance_id
        {
            get;
            set;
        }

        public System.Boolean active
        {
            get;
            set;
        }

        public System.Single heartbeat_timeout
        {
            get;
            set;
        }

        public System.Single heartbeat_period
        {
            get;
            set;
        }

        public Status(): base()
        {
        }

        public Status(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( id ) ) ; 
            binaryWriter.Write(instance_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( instance_id ) ) ; 
            binaryWriter.Write(active);
            binaryWriter.Write(heartbeat_timeout);
            binaryWriter.Write(heartbeat_period);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            instance_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            active = binaryReader.ReadBoolean();
            heartbeat_timeout = binaryReader.ReadSingle();
            heartbeat_period = binaryReader.ReadSingle();
        }
    }
}