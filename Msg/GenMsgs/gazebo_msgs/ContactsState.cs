namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/ContactsState", "acbcb1601a8e525bf72509f18e6f668d", "Header header                                   # stamp\ngazebo_msgs/ContactState[] states            # array of geom pairs in contact\n")]
    public partial class ContactsState : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public gazebo_msgs.ContactState[] states
        {
            get;
            set;
        }

        public ContactsState(): base()
        {
        }

        public ContactsState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(states.Length); for  ( int  i  =  0 ;  i < states . Length ;  i ++ ) states [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            states = new gazebo_msgs.ContactState[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < states . Length ;  i ++ ) states [ i ]  =  new  gazebo_msgs . ContactState ( binaryReader ) ; 
        }
    }
}