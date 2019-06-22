namespace Roslin.Msg.gps_common
{
    [MsgInfo("gps_common/GPSStatus", "313baa8951fdd056c78bf61b1b07d249", "Header header\n\n# Satellites used in solution\nuint16 satellites_used # Number of satellites\nint32[] satellite_used_prn # PRN identifiers\n\n# Satellites visible\nuint16 satellites_visible\nint32[] satellite_visible_prn # PRN identifiers\nint32[] satellite_visible_z # Elevation of satellites\nint32[] satellite_visible_azimuth # Azimuth of satellites\nint32[] satellite_visible_snr # Signal-to-noise ratios (dB)\n\n# Measurement status\nint16 STATUS_NO_FIX=-1   # Unable to fix position\nint16 STATUS_FIX=0       # Normal fix\nint16 STATUS_SBAS_FIX=1  # Fixed using a satellite-based augmentation system\nint16 STATUS_GBAS_FIX=2  #          or a ground-based augmentation system\nint16 STATUS_DGPS_FIX=18 # Fixed with DGPS\nint16 STATUS_WAAS_FIX=33 # Fixed with WAAS\nint16 status\n\nuint16 SOURCE_NONE=0 # No information is available\nuint16 SOURCE_GPS=1 # Using standard GPS location [only valid for position_source]\nuint16 SOURCE_POINTS=2 # Motion/orientation fix is derived from successive points\nuint16 SOURCE_DOPPLER=4 # Motion is derived using the Doppler effect\nuint16 SOURCE_ALTIMETER=8 # Using an altimeter\nuint16 SOURCE_MAGNETIC=16 # Using magnetic sensors\nuint16 SOURCE_GYRO=32 # Using gyroscopes\nuint16 SOURCE_ACCEL=64 # Using accelerometers\n\nuint16 motion_source # Source for speed, climb and track\nuint16 orientation_source # Source for device orientation\nuint16 position_source # Source for position\n\n")]
    public partial class GPSStatus : RosMsg
    {
        public System.Int16 STATUS_NO_FIX => -1;
        public System.Int16 STATUS_FIX => 0;
        public System.Int16 STATUS_SBAS_FIX => 1;
        public System.Int16 STATUS_GBAS_FIX => 2;
        public System.Int16 STATUS_DGPS_FIX => 18;
        public System.Int16 STATUS_WAAS_FIX => 33;
        public System.UInt16 SOURCE_NONE => 0;
        public System.UInt16 SOURCE_GPS => 1;
        public System.UInt16 SOURCE_POINTS => 2;
        public System.UInt16 SOURCE_DOPPLER => 4;
        public System.UInt16 SOURCE_ALTIMETER => 8;
        public System.UInt16 SOURCE_MAGNETIC => 16;
        public System.UInt16 SOURCE_GYRO => 32;
        public System.UInt16 SOURCE_ACCEL => 64;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt16 satellites_used
        {
            get;
            set;
        }

        public System.Int32[] satellite_used_prn
        {
            get;
            set;
        }

        public System.UInt16 satellites_visible
        {
            get;
            set;
        }

        public System.Int32[] satellite_visible_prn
        {
            get;
            set;
        }

        public System.Int32[] satellite_visible_z
        {
            get;
            set;
        }

        public System.Int32[] satellite_visible_azimuth
        {
            get;
            set;
        }

        public System.Int32[] satellite_visible_snr
        {
            get;
            set;
        }

        public System.Int16 status
        {
            get;
            set;
        }

        public System.UInt16 motion_source
        {
            get;
            set;
        }

        public System.UInt16 orientation_source
        {
            get;
            set;
        }

        public System.UInt16 position_source
        {
            get;
            set;
        }

        public GPSStatus(): base()
        {
        }

        public GPSStatus(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(satellites_used);
            binaryWriter.Write(satellite_used_prn.Length); for  ( int  i  =  0 ;  i < satellite_used_prn . Length ;  i ++ ) binaryWriter . Write ( satellite_used_prn [ i ] ) ; 
            binaryWriter.Write(satellites_visible);
            binaryWriter.Write(satellite_visible_prn.Length); for  ( int  i  =  0 ;  i < satellite_visible_prn . Length ;  i ++ ) binaryWriter . Write ( satellite_visible_prn [ i ] ) ; 
            binaryWriter.Write(satellite_visible_z.Length); for  ( int  i  =  0 ;  i < satellite_visible_z . Length ;  i ++ ) binaryWriter . Write ( satellite_visible_z [ i ] ) ; 
            binaryWriter.Write(satellite_visible_azimuth.Length); for  ( int  i  =  0 ;  i < satellite_visible_azimuth . Length ;  i ++ ) binaryWriter . Write ( satellite_visible_azimuth [ i ] ) ; 
            binaryWriter.Write(satellite_visible_snr.Length); for  ( int  i  =  0 ;  i < satellite_visible_snr . Length ;  i ++ ) binaryWriter . Write ( satellite_visible_snr [ i ] ) ; 
            binaryWriter.Write(status);
            binaryWriter.Write(motion_source);
            binaryWriter.Write(orientation_source);
            binaryWriter.Write(position_source);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            satellites_used = binaryReader.ReadUInt16();
            satellite_used_prn = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < satellite_used_prn . Length ;  i ++ ) satellite_used_prn [ i ]  =  binaryReader . ReadInt32 ( ) ; 
            satellites_visible = binaryReader.ReadUInt16();
            satellite_visible_prn = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < satellite_visible_prn . Length ;  i ++ ) satellite_visible_prn [ i ]  =  binaryReader . ReadInt32 ( ) ; 
            satellite_visible_z = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < satellite_visible_z . Length ;  i ++ ) satellite_visible_z [ i ]  =  binaryReader . ReadInt32 ( ) ; 
            satellite_visible_azimuth = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < satellite_visible_azimuth . Length ;  i ++ ) satellite_visible_azimuth [ i ]  =  binaryReader . ReadInt32 ( ) ; 
            satellite_visible_snr = new System.Int32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < satellite_visible_snr . Length ;  i ++ ) satellite_visible_snr [ i ]  =  binaryReader . ReadInt32 ( ) ; 
            status = binaryReader.ReadInt16();
            motion_source = binaryReader.ReadUInt16();
            orientation_source = binaryReader.ReadUInt16();
            position_source = binaryReader.ReadUInt16();
        }
    }
}