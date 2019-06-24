namespace Roslin.Msg.jsk_footstep_msgs
{
    [MsgInfo("jsk_footstep_msgs/FootstepArray", "385bc396845a4680214262a4679d83b3", @"Header header
Footstep[] footsteps")]
    public partial class FootstepArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Footstep[] footsteps
        {
            get;
            set;
        }

        public FootstepArray(): base()
        {
        }

        public FootstepArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(footsteps.Length); for  ( int  i  =  0 ;  i < footsteps . Length ;  i ++ ) footsteps [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            footsteps = new Footstep[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < footsteps . Length ;  i ++ ) footsteps [ i ]  =  new  Footstep ( binaryReader ) ; 
        }
    }
}