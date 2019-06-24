namespace Roslin.Msg.people_msgs
{
    [MsgInfo("people_msgs/Person", "0b7c0818b76476f3863bd13f4d59f8df", @"string              name
geometry_msgs/Point position
geometry_msgs/Point velocity
float64             reliability
string[]            tagnames
string[]            tags

")]
    public partial class Person : RosMsg
    {
        public System.String name
        {
            get;
            set;
        }

        public geometry_msgs.Point position
        {
            get;
            set;
        }

        public geometry_msgs.Point velocity
        {
            get;
            set;
        }

        public System.Double reliability
        {
            get;
            set;
        }

        public System.String[] tagnames
        {
            get;
            set;
        }

        public System.String[] tags
        {
            get;
            set;
        }

        public Person(): base()
        {
        }

        public Person(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            position.Serilize(binaryWriter);
            velocity.Serilize(binaryWriter);
            binaryWriter.Write(reliability);
            binaryWriter.Write(tagnames.Length); for  ( int  i  =  0 ;  i < tagnames . Length ;  i ++ ) { binaryWriter . Write ( tagnames [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( tagnames [ i ] ) ) ;  }
            binaryWriter.Write(tags.Length); for  ( int  i  =  0 ;  i < tags . Length ;  i ++ ) { binaryWriter . Write ( tags [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( tags [ i ] ) ) ;  }
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            position = new geometry_msgs.Point(binaryReader);
            velocity = new geometry_msgs.Point(binaryReader);
            reliability = binaryReader.ReadDouble();
            tagnames = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < tagnames . Length ;  i ++ ) tagnames [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            tags = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < tags . Length ;  i ++ ) tags [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
        }
    }
}