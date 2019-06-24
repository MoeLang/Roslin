namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/SimpleOccupancyGridArray", "e448b458270a6ec465d66169c4180932", @"Header header
SimpleOccupancyGrid[] grids
")]
    public partial class SimpleOccupancyGridArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public SimpleOccupancyGrid[] grids
        {
            get;
            set;
        }

        public SimpleOccupancyGridArray(): base()
        {
        }

        public SimpleOccupancyGridArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(grids.Length); for  ( int  i  =  0 ;  i < grids . Length ;  i ++ ) grids [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            grids = new SimpleOccupancyGrid[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < grids . Length ;  i ++ ) grids [ i ]  =  new  SimpleOccupancyGrid ( binaryReader ) ; 
        }
    }
}