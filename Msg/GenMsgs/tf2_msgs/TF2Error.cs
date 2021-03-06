namespace Roslin.Msg.tf2_msgs
{
    [MsgInfo("tf2_msgs/TF2Error", "bc6848fd6fd750c92e38575618a4917d", @"uint8 NO_ERROR = 0
uint8 LOOKUP_ERROR = 1
uint8 CONNECTIVITY_ERROR = 2
uint8 EXTRAPOLATION_ERROR = 3
uint8 INVALID_ARGUMENT_ERROR = 4
uint8 TIMEOUT_ERROR = 5
uint8 TRANSFORM_ERROR = 6

uint8 error
string error_string
")]
    public partial class TF2Error : RosMsg
    {
        public System.Byte NO_ERROR => 0;
        public System.Byte LOOKUP_ERROR => 1;
        public System.Byte CONNECTIVITY_ERROR => 2;
        public System.Byte EXTRAPOLATION_ERROR => 3;
        public System.Byte INVALID_ARGUMENT_ERROR => 4;
        public System.Byte TIMEOUT_ERROR => 5;
        public System.Byte TRANSFORM_ERROR => 6;
        public System.Byte error
        {
            get;
            set;
        }

        public System.String error_string
        {
            get;
            set;
        }

        public TF2Error(): base()
        {
        }

        public TF2Error(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(error);
            binaryWriter.Write(error_string.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( error_string ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            error = binaryReader.ReadByte();
            error_string = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}