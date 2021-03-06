namespace Roslin.Msg.nmea_msgs
{
    [MsgInfo("nmea_msgs/Sentence", "9f221efc5f4b3bac7ce4af102b32308b", @"# A message representing a single NMEA0183 sentence.

# header.stamp is the ROS Time when the sentence was read.
# header.frame_id is the frame of reference reported by the satellite
#        receiver, usually the location of the antenna.  This is a
#        Euclidean frame relative to the vehicle, not a reference
#        ellipsoid.
Header header

# This should only contain ASCII characters in order to be a valid NMEA0183 sentence.
string sentence
")]
    public partial class Sentence : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.String sentence
        {
            get;
            set;
        }

        public Sentence(): base()
        {
        }

        public Sentence(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(sentence.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( sentence ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            sentence = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}