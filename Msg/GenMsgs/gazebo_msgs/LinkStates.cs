namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/LinkStates", "48c080191eb15c41858319b4d8a609c2", @"# broadcast all link states in world frame
string[] name                 # link names
geometry_msgs/Pose[] pose     # desired pose in world frame
geometry_msgs/Twist[] twist   # desired twist in world frame
")]
    public partial class LinkStates : RosMsg
    {
        public System.String[] name
        {
            get;
            set;
        }

        public geometry_msgs.Pose[] pose
        {
            get;
            set;
        }

        public geometry_msgs.Twist[] twist
        {
            get;
            set;
        }

        public LinkStates(): base()
        {
        }

        public LinkStates(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); for  ( int  i  =  0 ;  i < name . Length ;  i ++ ) { binaryWriter . Write ( name [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name [ i ] ) ) ;  }
            binaryWriter.Write(pose.Length); for  ( int  i  =  0 ;  i < pose . Length ;  i ++ ) pose [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(twist.Length); for  ( int  i  =  0 ;  i < twist . Length ;  i ++ ) twist [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < name . Length ;  i ++ ) name [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            pose = new geometry_msgs.Pose[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < pose . Length ;  i ++ ) pose [ i ]  =  new  geometry_msgs . Pose ( binaryReader ) ; 
            twist = new geometry_msgs.Twist[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < twist . Length ;  i ++ ) twist [ i ]  =  new  geometry_msgs . Twist ( binaryReader ) ; 
        }
    }
}