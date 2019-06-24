namespace Roslin.Msg.jsk_footstep_msgs
{
    [MsgInfo("jsk_footstep_msgs/Footstep", "d890b275b63a90fe5f22a21e9a879971", @"uint8 RIGHT=2
uint8 LEFT=1

# Constants to visualize progress
uint8 REJECTED=3
uint8 APPROVED=4

## limb_indicator values
uint8 LLEG=1
uint8 RLEG=2
uint8 LARM=5
uint8 RARM=6

uint8 leg ## value should be one of limb_indicator values.
geometry_msgs/Pose pose ## 'pose' represents nominal pose. It may be an end-effector of limb.
duration duration
# optional parameters
uint32 footstep_group
geometry_msgs/Vector3 dimensions ## cube [length(x), width(y), height(z)]
geometry_msgs/Vector3 offset     ## offset from pose to center of cube
float32 swing_height
float32 cost
")]
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