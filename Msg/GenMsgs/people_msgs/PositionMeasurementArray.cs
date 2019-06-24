namespace Roslin.Msg.people_msgs
{
    [MsgInfo("people_msgs/PositionMeasurementArray", "59c860d40aa739ec920eb3ad24ae019e", @"Header          header

# All of the people found
people_msgs/PositionMeasurement[] people

# The co-occurrence matrix between people
float32[] cooccurrence")]
    public partial class PositionMeasurementArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public people_msgs.PositionMeasurement[] people
        {
            get;
            set;
        }

        public System.Single[] cooccurrence
        {
            get;
            set;
        }

        public PositionMeasurementArray(): base()
        {
        }

        public PositionMeasurementArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(people.Length); for  ( int  i  =  0 ;  i < people . Length ;  i ++ ) people [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(cooccurrence.Length); for  ( int  i  =  0 ;  i < cooccurrence . Length ;  i ++ ) binaryWriter . Write ( cooccurrence [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            people = new people_msgs.PositionMeasurement[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < people . Length ;  i ++ ) people [ i ]  =  new  people_msgs . PositionMeasurement ( binaryReader ) ; 
            cooccurrence = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cooccurrence . Length ;  i ++ ) cooccurrence [ i ]  =  binaryReader . ReadSingle ( ) ; 
        }
    }
}