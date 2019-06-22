namespace Roslin.Msg.dynamic_reconfigure
{
    [MsgInfo("dynamic_reconfigure/ParamDescription", "7434fcb9348c13054e0c3b267c8cb34d", "string name\nstring type\nuint32 level\nstring description\nstring edit_method\n")]
    public partial class ParamDescription : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public System.String type
        {
            get;
            set;
        }

        public System.UInt32 level
        {
            get;
            set;
        }

        public System.String description
        {
            get;
            set;
        }

        public System.String edit_method
        {
            get;
            set;
        }

        public ParamDescription(): base()
        {
        }

        public ParamDescription(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(type.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( type ) ) ; 
            binaryWriter.Write(level);
            binaryWriter.Write(description.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( description ) ) ; 
            binaryWriter.Write(edit_method.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( edit_method ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            type = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            level = binaryReader.ReadUInt32();
            description = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            edit_method = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}