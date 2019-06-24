namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/VinRpt", "9adca84caaa097b32fc7b71a0ca8da36", @"Header header

string mfg_code
string mfg
string model_year_code
uint32 model_year
uint32 serial
")]
    public partial class VinRpt : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String mfg_code
        {
            get;
            set;
        }

        public System.String mfg
        {
            get;
            set;
        }

        public System.String model_year_code
        {
            get;
            set;
        }

        public System.UInt32 model_year
        {
            get;
            set;
        }

        public System.UInt32 serial
        {
            get;
            set;
        }

        public VinRpt(): base()
        {
        }

        public VinRpt(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(mfg_code.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( mfg_code ) ) ; 
            binaryWriter.Write(mfg.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( mfg ) ) ; 
            binaryWriter.Write(model_year_code.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( model_year_code ) ) ; 
            binaryWriter.Write(model_year);
            binaryWriter.Write(serial);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            mfg_code = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            mfg = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            model_year_code = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            model_year = binaryReader.ReadUInt32();
            serial = binaryReader.ReadUInt32();
        }
    }
}