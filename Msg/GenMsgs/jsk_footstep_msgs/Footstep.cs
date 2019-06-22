namespace Roslin.Msg.jsk_footstep_msgs
{
    [MsgInfo("jsk_footstep_msgs/Footstep", "d890b275b63a90fe5f22a21e9a879971", "uint8 RIGHT=2\nuint8 LEFT=1\n\n# Constants to visualize progress\nuint8 REJECTED=3\nuint8 APPROVED=4\n\n## limb_indicator values\nuint8 LLEG=1\nuint8 RLEG=2\nuint8 LARM=5\nuint8 RARM=6\n\nuint8 leg ## value should be one of limb_indicator values.\ngeometry_msgs/Pose pose ## 'pose' represents nominal pose. It may be an end-effector of limb.\nduration duration\n# optional parameters\nuint32 footstep_group\ngeometry_msgs/Vector3 dimensions ## cube [length(x), width(y), height(z)]\ngeometry_msgs/Vector3 offset     ## offset from pose to center of cube\nfloat32 swing_height\nfloat32 cost\n")]
    public partial class Footstep : RosMsg
    {
        public System.Byte RIGHT => 2;
        public System.Byte LEFT => 1;
        public System.Byte REJECTED => 3;
        public System.Byte APPROVED => 4;
        public System.Byte LLEG => 1;
        public System.Byte RLEG => 2;
        public System.Byte LARM => 5;
        public System.Byte RARM => 6;
        public System.Byte leg
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public System.TimeSpan duration
        {
            get;
            set;
        }

        public System.UInt32 footstep_group
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 dimensions
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 offset
        {
            get;
            set;
        }

        public System.Single swing_height
        {
            get;
            set;
        }

        public System.Single cost
        {
            get;
            set;
        }

        public Footstep(): base()
        {
        }

        public Footstep(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(leg);
            pose.Serilize(binaryWriter);
            binaryWriter.Write(duration);
            binaryWriter.Write(footstep_group);
            dimensions.Serilize(binaryWriter);
            offset.Serilize(binaryWriter);
            binaryWriter.Write(swing_height);
            binaryWriter.Write(cost);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            leg = binaryReader.ReadByte();
            pose = new geometry_msgs.Pose(binaryReader);
            duration = binaryReader.ReadTimeSpan();
            footstep_group = binaryReader.ReadUInt32();
            dimensions = new geometry_msgs.Vector3(binaryReader);
            offset = new geometry_msgs.Vector3(binaryReader);
            swing_height = binaryReader.ReadSingle();
            cost = binaryReader.ReadSingle();
        }
    }
}