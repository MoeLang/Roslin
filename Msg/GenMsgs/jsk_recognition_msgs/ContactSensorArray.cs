namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ContactSensorArray", "c65f16fb3a523c0b77d7e31330b214da", @"std_msgs/Header header
jsk_recognition_msgs/ContactSensor[] datas")]
    public partial class ContactSensorArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public jsk_recognition_msgs.ContactSensor[] datas
        {
            get;
            set;
        }

        public ContactSensorArray(): base()
        {
        }

        public ContactSensorArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(datas.Length); for  ( int  i  =  0 ;  i < datas . Length ;  i ++ ) datas [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            datas = new jsk_recognition_msgs.ContactSensor[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < datas . Length ;  i ++ ) datas [ i ]  =  new  jsk_recognition_msgs . ContactSensor ( binaryReader ) ; 
        }
    }
}