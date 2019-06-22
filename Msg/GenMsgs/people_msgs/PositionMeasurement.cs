namespace Roslin.Msg.people_msgs
{
    [MsgInfo("people_msgs/PositionMeasurement", "54fa938b4ec28728e01575b79eb0ec7c", "Header          header\nstring          name\nstring          object_id\ngeometry_msgs/Point pos\nfloat64         reliability\nfloat64[9] 	covariance\nbyte            initialization")]
    public partial class PositionMeasurement : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String name
        {
            get;
            set;
        }

        public System.String object_id
        {
            get;
            set;
        }

        public geometry_msgs.Point pos
        {
            get;
            set;
        }

        public System.Double reliability
        {
            get;
            set;
        }

        public System.Double[] covariance
        {
            get;
            set;
        }

        public System.Byte initialization
        {
            get;
            set;
        }

        public PositionMeasurement(): base()
        {
        }

        public PositionMeasurement(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( name ) ) ; 
            binaryWriter.Write(object_id.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( object_id ) ) ; 
            pos.Serilize(binaryWriter);
            binaryWriter.Write(reliability);
            for (int i = 0; i < 9; i++)
                binaryWriter.Write(covariance[i]);
            binaryWriter.Write(initialization);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            object_id = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            pos = new geometry_msgs.Point(binaryReader);
            reliability = binaryReader.ReadDouble();
            covariance = new System.Double[9]; for  ( int  i  =  0 ;  i < 9 ;  i ++ ) covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
            initialization = binaryReader.ReadByte();
        }
    }
}