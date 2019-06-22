namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SystemCmdBool", "ebee3259c3c8f34dec0d921f3c0fa804", "Header header\n\nbool enable\nbool ignore_overrides\nbool clear_override\nbool clear_faults\n\nbool command\n")]
    public partial class SystemCmdBool : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean enable
        {
            get;
            set;
        }

        public System.Boolean ignore_overrides
        {
            get;
            set;
        }

        public System.Boolean clear_override
        {
            get;
            set;
        }

        public System.Boolean clear_faults
        {
            get;
            set;
        }

        public System.Boolean command
        {
            get;
            set;
        }

        public SystemCmdBool(): base()
        {
        }

        public SystemCmdBool(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(enable);
            binaryWriter.Write(ignore_overrides);
            binaryWriter.Write(clear_override);
            binaryWriter.Write(clear_faults);
            binaryWriter.Write(command);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            enable = binaryReader.ReadBoolean();
            ignore_overrides = binaryReader.ReadBoolean();
            clear_override = binaryReader.ReadBoolean();
            clear_faults = binaryReader.ReadBoolean();
            command = binaryReader.ReadBoolean();
        }
    }
}