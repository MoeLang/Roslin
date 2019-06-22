namespace Roslin.Msg.velodyne_msgs
{
    [MsgInfo("velodyne_msgs/VelodynePacket", "ae4f90a23256f44e82baa08dd45c3456", "# Raw Velodyne LIDAR packet.\n\ntime stamp              # packet timestamp\nuint8[1206] data        # packet contents\n\n")]
    public partial class VelodynePacket : RosMsg
    {
        public System.DateTime stamp
        {
            get;
            set;
        }

        public System.Byte[] data
        {
            get;
            set;
        }

        public VelodynePacket(): base()
        {
        }

        public VelodynePacket(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(stamp);
            binaryWriter.Write(data);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            stamp = binaryReader.ReadDateTime();
            data = new System.Byte[1206]; data  =  binaryReader . ReadBytes ( data . Length ) ; 
        }
    }
}