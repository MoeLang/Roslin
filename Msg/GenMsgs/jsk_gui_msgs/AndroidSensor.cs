namespace Roslin.Msg.jsk_gui_msgs
{
    [MsgInfo("jsk_gui_msgs/AndroidSensor", "d832dbe3be7e7f061d963f2188f1a407", @"# sonsor for Tablet
float64 accel_x
float64 accel_y
float64 accel_z
float64 orientation_x
float64 orientation_y
float64 orientation_z


")]
    public partial class AndroidSensor : RosMsg
    {
        public System.Double accel_x
        {
            get;
            set;
        }

        public System.Double accel_y
        {
            get;
            set;
        }

        public System.Double accel_z
        {
            get;
            set;
        }

        public System.Double orientation_x
        {
            get;
            set;
        }

        public System.Double orientation_y
        {
            get;
            set;
        }

        public System.Double orientation_z
        {
            get;
            set;
        }

        public AndroidSensor(): base()
        {
        }

        public AndroidSensor(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(accel_x);
            binaryWriter.Write(accel_y);
            binaryWriter.Write(accel_z);
            binaryWriter.Write(orientation_x);
            binaryWriter.Write(orientation_y);
            binaryWriter.Write(orientation_z);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            accel_x = binaryReader.ReadDouble();
            accel_y = binaryReader.ReadDouble();
            accel_z = binaryReader.ReadDouble();
            orientation_x = binaryReader.ReadDouble();
            orientation_y = binaryReader.ReadDouble();
            orientation_z = binaryReader.ReadDouble();
        }
    }
}