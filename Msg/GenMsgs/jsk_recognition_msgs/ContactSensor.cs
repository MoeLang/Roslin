namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ContactSensor", "364b2b952a51d85dfa877e334264e361", @"# Header
Header header

# Whether sensor detects contact or not
bool contact

string link_name
")]
    public partial class ContactSensor : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Boolean contact
        {
            get;
            set;
        }

        public System.String link_name
        {
            get;
            set;
        }

        public ContactSensor(): base()
        {
        }

        public ContactSensor(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(contact);
            binaryWriter.Write(link_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( link_name ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            contact = binaryReader.ReadBoolean();
            link_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}