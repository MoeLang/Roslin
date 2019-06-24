namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/MultiEchoLaserScan", "6fefb0c6da89d7c8abe4b339f5c2f8fb", @"# Single scan from a multi-echo planar laser range-finder
#
# If you have another ranging device with different behavior (e.g. a sonar
# array), please find or create a different message, since applications
# will make fairly laser-specific assumptions about this data

Header header            # timestamp in the header is the acquisition time of 
                         # the first ray in the scan.
                         #
                         # in frame frame_id, angles are measured around 
                         # the positive Z axis (counterclockwise, if Z is up)
                         # with zero angle being forward along the x axis
                         
float32 angle_min        # start angle of the scan [rad]
float32 angle_max        # end angle of the scan [rad]
float32 angle_increment  # angular distance between measurements [rad]

float32 time_increment   # time between measurements [seconds] - if your scanner
                         # is moving, this will be used in interpolating position
                         # of 3d points
float32 scan_time        # time between scans [seconds]

float32 range_min        # minimum range value [m]
float32 range_max        # maximum range value [m]

LaserEcho[] ranges       # range data [m] (Note: NaNs, values < range_min or > range_max should be discarded)
                         # +Inf measurements are out of range
                         # -Inf measurements are too close to determine exact distance.
LaserEcho[] intensities  # intensity data [device-specific units].  If your
                         # device does not provide intensities, please leave
                         # the array empty.")]
    public partial class MultiEchoLaserScan : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single angle_min
        {
            get;
            set;
        }

        public System.Single angle_max
        {
            get;
            set;
        }

        public System.Single angle_increment
        {
            get;
            set;
        }

        public System.Single time_increment
        {
            get;
            set;
        }

        public System.Single scan_time
        {
            get;
            set;
        }

        public System.Single range_min
        {
            get;
            set;
        }

        public System.Single range_max
        {
            get;
            set;
        }

        public LaserEcho[] ranges
        {
            get;
            set;
        }

        public LaserEcho[] intensities
        {
            get;
            set;
        }

        public MultiEchoLaserScan(): base()
        {
        }

        public MultiEchoLaserScan(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(angle_min);
            binaryWriter.Write(angle_max);
            binaryWriter.Write(angle_increment);
            binaryWriter.Write(time_increment);
            binaryWriter.Write(scan_time);
            binaryWriter.Write(range_min);
            binaryWriter.Write(range_max);
            binaryWriter.Write(ranges.Length); for  ( int  i  =  0 ;  i < ranges . Length ;  i ++ ) ranges [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(intensities.Length); for  ( int  i  =  0 ;  i < intensities . Length ;  i ++ ) intensities [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            angle_min = binaryReader.ReadSingle();
            angle_max = binaryReader.ReadSingle();
            angle_increment = binaryReader.ReadSingle();
            time_increment = binaryReader.ReadSingle();
            scan_time = binaryReader.ReadSingle();
            range_min = binaryReader.ReadSingle();
            range_max = binaryReader.ReadSingle();
            ranges = new LaserEcho[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < ranges . Length ;  i ++ ) ranges [ i ]  =  new  LaserEcho ( binaryReader ) ; 
            intensities = new LaserEcho[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < intensities . Length ;  i ++ ) intensities [ i ]  =  new  LaserEcho ( binaryReader ) ; 
        }
    }
}