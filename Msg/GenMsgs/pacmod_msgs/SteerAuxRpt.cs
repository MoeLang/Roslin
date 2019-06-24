namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SteerAuxRpt", "64ab1937ad919cdc25271e7f81c721e2", @"Header header

float64 raw_position
bool raw_position_is_valid
float64 raw_torque
bool raw_torque_is_valid
float64 rotation_rate
bool rotation_rate_is_valid
bool user_interaction
bool user_interaction_is_valid
")]
    public partial class SteerAuxRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double raw_position
        {
            get;
            set;
        }

        public System.Boolean raw_position_is_valid
        {
            get;
            set;
        }

        public System.Double raw_torque
        {
            get;
            set;
        }

        public System.Boolean raw_torque_is_valid
        {
            get;
            set;
        }

        public System.Double rotation_rate
        {
            get;
            set;
        }

        public System.Boolean rotation_rate_is_valid
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

        public SteerAuxRpt(): base()
        {
        }

        public SteerAuxRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(raw_position);
            binaryWriter.Write(raw_position_is_valid);
            binaryWriter.Write(raw_torque);
            binaryWriter.Write(raw_torque_is_valid);
            binaryWriter.Write(rotation_rate);
            binaryWriter.Write(rotation_rate_is_valid);
            binaryWriter.Write(user_interaction);
            binaryWriter.Write(user_interaction_is_valid);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            raw_position = binaryReader.ReadDouble();
            raw_position_is_valid = binaryReader.ReadBoolean();
            raw_torque = binaryReader.ReadDouble();
            raw_torque_is_valid = binaryReader.ReadBoolean();
            rotation_rate = binaryReader.ReadDouble();
            rotation_rate_is_valid = binaryReader.ReadBoolean();
            user_interaction = binaryReader.ReadBoolean();
            user_interaction_is_valid = binaryReader.ReadBoolean();
        }
    }
}