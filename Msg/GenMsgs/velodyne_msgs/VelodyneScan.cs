namespace Roslin.Msg.velodyne_msgs
{
    [MsgInfo("velodyne_msgs/VelodyneScan", "50804fc9533a0e579e6322c04ae70566", "# Velodyne LIDAR scan packets.\n\nHeader           header         # standard ROS message header\nVelodynePacket[] packets        # vector of raw packets\n")]
    public partial class VelodyneScan : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public VelodynePacket[] packets
        {
            get;
            set;
        }

        public VelodyneScan(): base()
        {
        }

        public VelodyneScan(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(packets.Length); for  ( int  i  =  0 ;  i < packets . Length ;  i ++ ) packets [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            packets = new VelodynePacket[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < packets . Length ;  i ++ ) packets [ i ]  =  new  VelodynePacket ( binaryReader ) ; 
        }
    }
}