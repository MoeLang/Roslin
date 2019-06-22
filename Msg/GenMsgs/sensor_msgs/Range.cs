namespace Roslin.Msg.sensor_msgs
{
    [MsgInfo("sensor_msgs/Range", "c005c34273dc426c67a020a87bc24148", "# Single range reading from an active ranger that emits energy and reports\n# one range reading that is valid along an arc at the distance measured. \n# This message is  not appropriate for laser scanners. See the LaserScan\n# message if you are working with a laser scanner.\n\n# This message also can represent a fixed-distance (binary) ranger.  This\n# sensor will have min_range===max_range===distance of detection.\n# These sensors follow REP 117 and will output -Inf if the object is detected\n# and +Inf if the object is outside of the detection range.\n\nHeader header           # timestamp in the header is the time the ranger\n                        # returned the distance reading\n\n# Radiation type enums\n# If you want a value added to this list, send an email to the ros-users list\nuint8 ULTRASOUND=0\nuint8 INFRARED=1\n\nuint8 radiation_type    # the type of radiation used by the sensor\n                        # (sound, IR, etc) [enum]\n\nfloat32 field_of_view   # the size of the arc that the distance reading is\n                        # valid for [rad]\n                        # the object causing the range reading may have\n                        # been anywhere within -field_of_view/2 and\n                        # field_of_view/2 at the measured range. \n                        # 0 angle corresponds to the x-axis of the sensor.\n\nfloat32 min_range       # minimum range value [m]\nfloat32 max_range       # maximum range value [m]\n                        # Fixed distance rangers require min_range==max_range\n\nfloat32 range           # range data [m]\n                        # (Note: values < range_min or > range_max\n                        # should be discarded)\n                        # Fixed distance rangers only output -Inf or +Inf.\n                        # -Inf represents a detection within fixed distance.\n                        # (Detection too close to the sensor to quantify)\n                        # +Inf represents no detection within the fixed distance.\n                        # (Object out of range)")]
    public partial class Range : RosMsg
    {
        public System.Byte ULTRASOUND => 0;
        public System.Byte INFRARED => 1;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Byte radiation_type
        {
            get;
            set;
        }

        public System.Single field_of_view
        {
            get;
            set;
        }

        public System.Single min_range
        {
            get;
            set;
        }

        public System.Single max_range
        {
            get;
            set;
        }

        public System.Single range
        {
            get;
            set;
        }

        public Range(): base()
        {
        }

        public Range(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(radiation_type);
            binaryWriter.Write(field_of_view);
            binaryWriter.Write(min_range);
            binaryWriter.Write(max_range);
            binaryWriter.Write(range);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            radiation_type = binaryReader.ReadByte();
            field_of_view = binaryReader.ReadSingle();
            min_range = binaryReader.ReadSingle();
            max_range = binaryReader.ReadSingle();
            range = binaryReader.ReadSingle();
        }
    }
}