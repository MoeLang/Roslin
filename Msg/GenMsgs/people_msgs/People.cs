namespace Roslin.Msg.people_msgs
{
    [MsgInfo("people_msgs/People", "18722f4b8db20cc2369740732357847b", "Header header\npeople_msgs/Person[] people\n")]
    public partial class People : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public people_msgs.Person[] people
        {
            get;
            set;
        }

        public People(): base()
        {
        }

        public People(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(people.Length); for  ( int  i  =  0 ;  i < people . Length ;  i ++ ) people [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            people = new people_msgs.Person[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < people . Length ;  i ++ ) people [ i ]  =  new  people_msgs . Person ( binaryReader ) ; 
        }
    }
}