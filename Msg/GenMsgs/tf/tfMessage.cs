namespace Roslin.Msg.tf
{
    [MsgInfo("tf/tfMessage", "94810edda583a504dfda3829e70d7eec", "geometry_msgs/TransformStamped[] transforms\n")]
    public partial class tfMessage : RosMsg
    {
        public geometry_msgs.TransformStamped[] transforms
        {
            get;
            set;
        }

        public tfMessage(): base()
        {
        }

        public tfMessage(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(transforms.Length); for  ( int  i  =  0 ;  i < transforms . Length ;  i ++ ) transforms [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            transforms = new geometry_msgs.TransformStamped[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < transforms . Length ;  i ++ ) transforms [ i ]  =  new  geometry_msgs . TransformStamped ( binaryReader ) ; 
        }
    }
}