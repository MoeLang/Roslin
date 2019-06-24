namespace Roslin.Msg.automotive_platform_msgs
{
    [MsgInfo("automotive_platform_msgs/Speed", "19e5d1450bb352242868b04367a49847", @"# Speed Control Message
# Contains speed commands

std_msgs/Header header

string module_name # module name of the source node of this message

float32 speed                # Desired speed (m/sec)
float32 acceleration_limit   # Max acceleration limit (m/sec^2)
float32 deceleration_limit   # Max deceleration limit (m/sec^2)

")]
    public partial class Speed : RosMsg
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

        public System.Single speed
        {
            get;
            set;
        }

        public System.Single acceleration_limit
        {
            get;
            set;
        }

        public System.Single deceleration_limit
        {
            get;
            set;
        }

        public Speed(): base()
        {
        }

        public Speed(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(module_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( module_name ) ) ; 
            binaryWriter.Write(speed);
            binaryWriter.Write(acceleration_limit);
            binaryWriter.Write(deceleration_limit);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            module_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            speed = binaryReader.ReadSingle();
            acceleration_limit = binaryReader.ReadSingle();
            deceleration_limit = binaryReader.ReadSingle();
        }
    }
}