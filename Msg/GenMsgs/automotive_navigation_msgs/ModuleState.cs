namespace Roslin.Msg.automotive_navigation_msgs
{
    [MsgInfo("automotive_navigation_msgs/ModuleState", "88626a2a97afc94b31bcdaefcc4271ef", "# Module State Message\n# Contains the state of a module\n\nstd_msgs/Header header\n\nstring name     # Module's name of the source node of this message\n\nstring state    # Current state\n\nstring info     # Information on current state\n\n")]
    public partial class ModuleState : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public System.String state
        {
            get;
            set;
        }

        public System.String info
        {
            get;
            set;
        }

        public ModuleState(): base()
        {
        }

        public ModuleState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(state.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( state ) ) ; 
            binaryWriter.Write(info.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( info ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            state = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            info = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}