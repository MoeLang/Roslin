namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/BrakeAuxRpt", "1b24f296f5fabbe64603c0988f5aae5b", @"Header header

float64 raw_pedal_pos
bool raw_pedal_pos_is_valid
float64 raw_pedal_force
bool raw_pedal_force_is_valid
float64 raw_brake_pressure
bool raw_brake_pressure_is_valid
bool brake_on_off
bool brake_on_off_is_valid
bool user_interaction
bool user_interaction_is_valid
")]
    public partial class BrakeAuxRpt : RosMsg
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

        public System.Double raw_brake_pressure
        {
            get;
            set;
        }

        public System.Boolean raw_brake_pressure_is_valid
        {
            get;
            set;
        }

        public System.Boolean brake_on_off
        {
            get;
            set;
        }

        public System.Boolean brake_on_off_is_valid
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

        public BrakeAuxRpt(): base()
        {
        }

        public BrakeAuxRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(raw_pedal_pos);
            binaryWriter.Write(raw_pedal_pos_is_valid);
            binaryWriter.Write(raw_pedal_force);
            binaryWriter.Write(raw_pedal_force_is_valid);
            binaryWriter.Write(raw_brake_pressure);
            binaryWriter.Write(raw_brake_pressure_is_valid);
            binaryWriter.Write(brake_on_off);
            binaryWriter.Write(brake_on_off_is_valid);
            binaryWriter.Write(user_interaction);
            binaryWriter.Write(user_interaction_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            raw_pedal_pos = binaryReader.ReadDouble();
            raw_pedal_pos_is_valid = binaryReader.ReadBoolean();
            raw_pedal_force = binaryReader.ReadDouble();
            raw_pedal_force_is_valid = binaryReader.ReadBoolean();
            raw_brake_pressure = binaryReader.ReadDouble();
            raw_brake_pressure_is_valid = binaryReader.ReadBoolean();
            brake_on_off = binaryReader.ReadBoolean();
            brake_on_off_is_valid = binaryReader.ReadBoolean();
            user_interaction = binaryReader.ReadBoolean();
            user_interaction_is_valid = binaryReader.ReadBoolean();
        }
    }
}