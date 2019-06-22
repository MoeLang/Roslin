namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/Imu", "6a62c6daae103f4ff57a132d6f95cec2", "# This is a message to hold data from an IMU (Inertial Measurement Unit)\n#\n# Accelerations should be in m/s^2 (not in g's), and rotational velocity should be in rad/sec\n#\n# If the covariance of the measurement is known, it should be filled in (if all you know is the \n# variance of each measurement, e.g. from the datasheet, just put those along the diagonal)\n# A covariance matrix of all zeros will be interpreted as \"covariance unknown\", and to use the\n# data a covariance will have to be assumed or gotten from some other source\n#\n# If you have no estimate for one of the data elements (e.g. your IMU doesn't produce an orientation \n# estimate), please set element 0 of the associated covariance matrix to -1\n# If you are interpreting this message, please check for a value of -1 in the first element of each \n# covariance matrix, and disregard the associated estimate.\n\nHeader header\n\ngeometry_msgs/Quaternion orientation\nfloat64[9] orientation_covariance # Row major about x, y, z axes\n\ngeometry_msgs/Vector3 angular_velocity\nfloat64[9] angular_velocity_covariance # Row major about x, y, z axes\n\ngeometry_msgs/Vector3 linear_acceleration\nfloat64[9] linear_acceleration_covariance # Row major x, y z \n")]
    public partial class Imu : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public geometry_msgs.Quaternion orientation
        {
            get;
            set;
        }

        public System.Double[] orientation_covariance
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 angular_velocity
        {
            get;
            set;
        }

        public System.Double[] angular_velocity_covariance
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 linear_acceleration
        {
            get;
            set;
        }

        public System.Double[] linear_acceleration_covariance
        {
            get;
            set;
        }

        public Imu(): base()
        {
        }

        public Imu(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            orientation.Serilize(binaryWriter);
            for (int i = 0; i < 9; i++)
                binaryWriter.Write(orientation_covariance[i]);
            angular_velocity.Serilize(binaryWriter);
            for (int i = 0; i < 9; i++)
                binaryWriter.Write(angular_velocity_covariance[i]);
            linear_acceleration.Serilize(binaryWriter);
            for (int i = 0; i < 9; i++)
                binaryWriter.Write(linear_acceleration_covariance[i]);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            orientation = new geometry_msgs.Quaternion(binaryReader);
            orientation_covariance = new System.Double[9]; for  ( int  i  =  0 ;  i < 9 ;  i ++ ) orientation_covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
            angular_velocity = new geometry_msgs.Vector3(binaryReader);
            angular_velocity_covariance = new System.Double[9]; for  ( int  i  =  0 ;  i < 9 ;  i ++ ) angular_velocity_covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
            linear_acceleration = new geometry_msgs.Vector3(binaryReader);
            linear_acceleration_covariance = new System.Double[9]; for  ( int  i  =  0 ;  i < 9 ;  i ++ ) linear_acceleration_covariance [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}