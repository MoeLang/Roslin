namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/Label", "8fe5a440459dcada9c353c016dfb49d2", "int32 id\nstring name\n")]
    public partial class Label : RosMsg
    {
        public System.Int32 id
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public Label(): base()
        {
        }

        public Label(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(id);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            id = binaryReader.ReadInt32();
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}