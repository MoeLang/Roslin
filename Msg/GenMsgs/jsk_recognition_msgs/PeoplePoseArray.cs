namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/PeoplePoseArray", "57d49e8e639421734a0ce15bfde9d80d", "Header header\njsk_recognition_msgs/PeoplePose[] poses\n")]
    public partial class PeoplePoseArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public jsk_recognition_msgs.PeoplePose[] poses
        {
            get;
            set;
        }

        public PeoplePoseArray(): base()
        {
        }

        public PeoplePoseArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(poses.Length); for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            poses = new jsk_recognition_msgs.PeoplePose[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ]  =  new  jsk_recognition_msgs . PeoplePose ( binaryReader ) ; 
        }
    }
}