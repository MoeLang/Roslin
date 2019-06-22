namespace Roslin.Msg.posedetection_msgs
{
    [MsgInfo("posedetection_msgs/Object6DPose", "68aad97d55c4f9555772eee1814bb3c7", "# 6D pose of object\ngeometry_msgs/Pose pose\n# reliability\nfloat32 reliability\n\n# type of object, usually contains the filename of the object that allows the receiving side to visualize it\n# can also be used as a unique type id\nstring type \n")]
    public partial class Object6DPose : RosMsg
    {
        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public System.Single reliability
        {
            get;
            set;
        }

        public System.String type
        {
            get;
            set;
        }

        public Object6DPose(): base()
        {
        }

        public Object6DPose(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            pose.Serilize(binaryWriter);
            binaryWriter.Write(reliability);
            binaryWriter.Write(type.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( type ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            pose = new geometry_msgs.Pose(binaryReader);
            reliability = binaryReader.ReadSingle();
            type = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}