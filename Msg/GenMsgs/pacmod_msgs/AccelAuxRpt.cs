namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/AccelAuxRpt", "2f644f02020323fdb0afab1a11b54b70", @"Header header

float64 raw_pedal_pos
bool raw_pedal_pos_is_valid
float64 raw_pedal_force
bool raw_pedal_force_is_valid
bool user_interaction
bool user_interaction_is_valid
bool brake_interlock_active
bool brake_interlock_active_is_valid
")]
    public partial class AccelAuxRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double raw_pedal_pos
        {
            get;
            set;
        }

        public System.Boolean raw_pedal_pos_is_valid
        {
            get;
            set;
        }

        public System.Double raw_pedal_force
        {
            get;
            set;
        }

        public System.Boolean raw_pedal_force_is_valid
        {
            get;
            set;
        }

        public System.Boolean user_interaction
        {
            get;
            set;
        }

        public System.Boolean user_interaction_is_valid
        {
            get;
            set;
        }

        public System.Boolean brake_interlock_active
        {
            get;
            set;
        }

        public System.Boolean brake_interlock_active_is_valid
        {
            get;
            set;
        }

        public AccelAuxRpt(): base()
        {
        }

        public AccelAuxRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(raw_pedal_pos);
            binaryWriter.Write(raw_pedal_pos_is_valid);
            binaryWriter.Write(raw_pedal_force);
            binaryWriter.Write(raw_pedal_force_is_valid);
            binaryWriter.Write(user_interaction);
            binaryWriter.Write(user_interaction_is_valid);
            binaryWriter.Write(brake_interlock_active);
            binaryWriter.Write(brake_interlock_active_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            raw_pedal_pos = binaryReader.ReadDouble();
            raw_pedal_pos_is_valid = binaryReader.ReadBoolean();
            raw_pedal_force = binaryReader.ReadDouble();
            raw_pedal_force_is_valid = binaryReader.ReadBoolean();
            user_interaction = binaryReader.ReadBoolean();
            user_interaction_is_valid = binaryReader.ReadBoolean();
            brake_interlock_active = binaryReader.ReadBoolean();
            brake_interlock_active_is_valid = binaryReader.ReadBoolean();
        }
    }
}