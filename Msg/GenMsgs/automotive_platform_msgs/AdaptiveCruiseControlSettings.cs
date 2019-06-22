namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/AdaptiveCruiseControlSettings", "0b4d1a2cc78ca8e10ffb5792b0e4db08", "# Adaptive Cruise Control Settings Message\n# Contains the current settings/status of ACC\n\nHeader header\n\nfloat32 set_speed       # Current speed set point (m/sec)\n\nuint16 following_spot   # Discrete following location\n                        # 0 = following distance is the minimum allowed distance\n                        # n = following distance is the maximum allowed distance\n                        #      where (n + 1) is the number of allowed distances\n\nfloat32 min_percent     # Minimum distance relative to maximum allowed distance\n                        # 0 to 1.0\n\nfloat32 step_percent    # Distance between spots relative to maximum allowed\n                        # distance\n                        # 0 to 1.0\n\nfloat32 cipv_percent    # Where CIPV is relative to the maximum allowed distance\n                        # 0 = there isn't a detected CIPV\n                        # 1.0 = the CIPV is at the maximum allowed distance\n                        # The maximum allowed distance varies with speed\n\nfloat32 max_distance    # The distance corresponding to 1.0 percent (meters)\n\n# So if the driver wants to maintain the greatest separation behind the CIPV,\n# he can press the increase distance button over and over until the distance\n# set point reaches the maximum allowed distance.  If there are 5 allowed\n# following distance set points, then following_spot will equal 4.\n\n# If a Closest In Path Vehicle is detected at this distance then the\n# cipv_percent will be 1.0.\n")]
    public partial class AdaptiveCruiseControlSettings : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single set_speed
        {
            get;
            set;
        }

        public System.UInt16 following_spot
        {
            get;
            set;
        }

        public System.Single min_percent
        {
            get;
            set;
        }

        public System.Single step_percent
        {
            get;
            set;
        }

        public System.Single cipv_percent
        {
            get;
            set;
        }

        public System.Single max_distance
        {
            get;
            set;
        }

        public AdaptiveCruiseControlSettings(): base()
        {
        }

        public AdaptiveCruiseControlSettings(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(set_speed);
            binaryWriter.Write(following_spot);
            binaryWriter.Write(min_percent);
            binaryWriter.Write(step_percent);
            binaryWriter.Write(cipv_percent);
            binaryWriter.Write(max_distance);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            set_speed = binaryReader.ReadSingle();
            following_spot = binaryReader.ReadUInt16();
            min_percent = binaryReader.ReadSingle();
            step_percent = binaryReader.ReadSingle();
            cipv_percent = binaryReader.ReadSingle();
            max_distance = binaryReader.ReadSingle();
        }
    }
}