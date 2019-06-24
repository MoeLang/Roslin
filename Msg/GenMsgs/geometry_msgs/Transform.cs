namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Transform", "ac9eff44abf714214112b05d54a3cf9b", @"# This represents the transform between two coordinate frames in free space.

Vector3 translation
Quaternion rotation
")]
    public partial class Transform : RosMsg
    {
        public Vector3 translation
        {
            get;
            set;
        }

        public Quaternion rotation
        {
            get;
            set;
        }

        public Transform(): base()
        {
        }

        public Transform(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            translation.Serilize(binaryWriter);
            rotation.Serilize(binaryWriter);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            translation = new Vector3(binaryReader);
            rotation = new Quaternion(binaryReader);
        }
    }
}