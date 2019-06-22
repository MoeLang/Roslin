namespace Roslin.Msg.audio_common_msgs
{
    [MsgInfo("audio_common_msgs/AudioData", "f43a8e1b362b75baa741461b46adc7e0", "uint8[] data\n")]
    public partial class AudioData : RosMsg
    {
        public System.Byte[] data
        {
            get;
            set;
        }

        public AudioData(): base()
        {
        }

        public AudioData(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(data.Length); binaryWriter . Write ( data ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            data = new System.Byte[binaryReader.ReadInt32()]; data  =  binaryReader . ReadBytes ( data . Length ) ; 
        }
    }
}