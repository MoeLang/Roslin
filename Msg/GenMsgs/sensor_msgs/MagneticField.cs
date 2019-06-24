namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/MagneticField", "2f3b0b43eed0c9501de0fa3ff89a45aa", @" # Measurement of the Magnetic Field vector at a specific location.

 # If the covariance of the measurement is known, it should be filled in
 # (if all you know is the variance of each measurement, e.g. from the datasheet,
 #just put those along the diagonal)
 # A covariance matrix of all zeros will be interpreted as ""covariance unknown"",
 # and to use the data a covariance will have to be assumed or gotten from some
 # other source


 Header header                        # timestamp is the time the
                                      # field was measured
                                      # frame_id is the location and orientation
                                      # of the field measurement

 geometry_msgs/Vector3 magnetic_field # x, y, and z components of the
                                      # field vector in Tesla
                                      # If your sensor does not output 3 axes,
                                      # put NaNs in the components not reported.

 float64[9] magnetic_field_covariance # Row major about x, y, z axes
                                      # 0 is interpreted as variance unknown")]
    public partial class MagneticField : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 magnetic_field
        {
            get;
            set;
        }

        public System.Double[] magnetic_field_covariance
        {
            get;
            set;
        }

        public MagneticField(): base()
        {
        }

        public MagneticField(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            magnetic_field.Serilize(binaryWriter);
            for (int i = 0; i < 9; i++)
                binaryWriter.Write(magnetic_field_covariance[i]);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            magnetic_field = new geometry_msgs.Vector3(binaryReader);
            magnetic_field_covariance = new System.Double[9]; for  ( int  i  =  0 ;  i < 9 ;  i ++ ) magnetic_field_covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}