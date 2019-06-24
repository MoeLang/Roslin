namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/ModelState", "9330fd35f2fcd82d457e54bd54e10593", @"# Set Gazebo Model pose and twist
string model_name           # model to set state (pose and twist)
geometry_msgs/Pose pose     # desired pose in reference frame
geometry_msgs/Twist twist   # desired twist in reference frame
string reference_frame      # set pose/twist relative to the frame of this entity (Body/Model)
                            # leave empty or ""world"" or ""map"" defaults to world-frame

")]
    public partial class ModelState : RosMsg
    {
        public System.String model_name
        {
            get;
            set;
        }

        public geometry_msgs.Pose pose
        {
            get;
            set;
        }

        public geometry_msgs.Twist twist
        {
            get;
            set;
        }

        public System.String reference_frame
        {
            get;
            set;
        }

        public ModelState(): base()
        {
        }

        public ModelState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(model_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( model_name ) ) ; 
            pose.Serilize(binaryWriter);
            twist.Serilize(binaryWriter);
            binaryWriter.Write(reference_frame.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( reference_frame ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            model_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            pose = new geometry_msgs.Pose(binaryReader);
            twist = new geometry_msgs.Twist(binaryReader);
            reference_frame = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}