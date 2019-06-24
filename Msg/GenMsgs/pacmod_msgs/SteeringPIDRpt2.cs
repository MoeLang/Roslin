namespace Roslin.Msg.pacmod_msgs
{
    [MsgInfo("pacmod_msgs/SteeringPIDRpt2", "f1f83d8c039cc71a4428f154e85e90eb", @"Header header

float64 P_term         
float64 I_term  
float64 D_term         
float64 all_terms      # sum of P, I, and D terms
")]
    public partial class SteeringPIDRpt2 : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Double P_term
        {
            get;
            set;
        }

        public System.Double I_term
        {
            get;
            set;
        }

        public System.Double D_term
        {
            get;
            set;
        }

        public System.Double all_terms
        {
            get;
            set;
        }

        public SteeringPIDRpt2(): base()
        {
        }

        public SteeringPIDRpt2(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(P_term);
            binaryWriter.Write(I_term);
            binaryWriter.Write(D_term);
            binaryWriter.Write(all_terms);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            P_term = binaryReader.ReadDouble();
            I_term = binaryReader.ReadDouble();
            D_term = binaryReader.ReadDouble();
            all_terms = binaryReader.ReadDouble();
        }
    }
}