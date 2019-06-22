namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/GroupState", "a2d87f51dc22930325041a2f8b1571f8", "string name\nbool state\nint32 id\nint32 parent\n")]
    public partial class GroupState : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.Boolean state
        {
            get;
            set;
        }

        public System.Int32 id
        {
            get;
            set;
        }

        public System.Int32 parent
        {
            get;
            set;
        }

        public GroupState(): base()
        {
        }

        public GroupState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(state);
            binaryWriter.Write(id);
            binaryWriter.Write(parent);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            state = binaryReader.ReadBoolean();
            id = binaryReader.ReadInt32();
            parent = binaryReader.ReadInt32();
        }
    }
}