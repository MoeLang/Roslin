namespace Roslin.Msg.people_msgs
{
    [MsgInfo("people_msgs/PersonStamped", "4a352a8b709eb9fec941a4f0f42651e7", @"Header header
people_msgs/Person person

")]
    public partial class PersonStamped : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public people_msgs.Person person
        {
            get;
            set;
        }

        public PersonStamped(): base()
        {
        }

        public PersonStamped(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            person.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            person = new people_msgs.Person(binaryReader);
        }
    }
}