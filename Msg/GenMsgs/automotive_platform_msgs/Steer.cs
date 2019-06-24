namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/Steer", "707dbbe00e6de0f2a6ed7a28a1389dc7", @"# Steering Control Message
# Contains steering commands

std_msgs/Header header

string module_name # module name of the source node of this message

float32 curvature           # Desired steering curvature (1/m)
float32 max_curvature_rate  # Max rate of change for curvature (1/m/sec)


")]
    public partial class Steer : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String module_name
        {
            get;
            set;
        }

        public System.Single curvature
        {
            get;
            set;
        }

        public System.Single max_curvature_rate
        {
            get;
            set;
        }

        public Steer(): base()
        {
        }

        public Steer(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(module_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( module_name ) ) ; 
            binaryWriter.Write(curvature);
            binaryWriter.Write(max_curvature_rate);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            module_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            curvature = binaryReader.ReadSingle();
            max_curvature_rate = binaryReader.ReadSingle();
        }
    }
}