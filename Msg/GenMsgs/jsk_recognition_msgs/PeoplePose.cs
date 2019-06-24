namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/PeoplePose", "24f6e59dae1b7cbd9d480f0008a5a515", @"string[] limb_names
geometry_msgs/Pose[] poses
float32[] scores")]
    public partial class PeoplePose : RosMsg
    {
        public System.String[] limb_names
        {
            get;
            set;
        }

        public geometry_msgs.Pose[] poses
        {
            get;
            set;
        }

        public System.Single[] scores
        {
            get;
            set;
        }

        public PeoplePose(): base()
        {
        }

        public PeoplePose(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(limb_names.Length); for  ( int  i  =  0 ;  i < limb_names . Length ;  i ++ ) { binaryWriter . Write ( limb_names [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( limb_names [ i ] ) ) ;  }
            binaryWriter.Write(poses.Length); for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(scores.Length); for  ( int  i  =  0 ;  i < scores . Length ;  i ++ ) binaryWriter . Write ( scores [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            limb_names = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < limb_names . Length ;  i ++ ) limb_names [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            poses = new geometry_msgs.Pose[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < poses . Length ;  i ++ ) poses [ i ]  =  new  geometry_msgs . Pose ( binaryReader ) ; 
            scores = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < scores . Length ;  i ++ ) scores [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}