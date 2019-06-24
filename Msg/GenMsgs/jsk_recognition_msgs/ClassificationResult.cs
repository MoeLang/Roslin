namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/ClassificationResult", "cce1f8edabff85a20e9cc013e319497c", @"# information about frame and timestamp
Header header

# prediction results
uint32[] labels          # numerical labels
string[] label_names     # non-numerical labels
float64[] label_proba    # probabilities of labels
float64[] probabilities  # probabilities about each classification for all target_names

# information about classifier
string classifier        # name of classifier
string[] target_names    # set in which label_names should be
")]
    public partial class ClassificationResult : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.UInt32[] labels
        {
            get;
            set;
        }

        public System.String[] label_names
        {
            get;
            set;
        }

        public System.Double[] label_proba
        {
            get;
            set;
        }

        public System.Double[] probabilities
        {
            get;
            set;
        }

        public System.String classifier
        {
            get;
            set;
        }

        public System.String[] target_names
        {
            get;
            set;
        }

        public ClassificationResult(): base()
        {
        }

        public ClassificationResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(labels.Length); for  ( int  i  =  0 ;  i < labels . Length ;  i ++ ) binaryWriter . Write ( labels [ i ] ) ; 
            binaryWriter.Write(label_names.Length); for  ( int  i  =  0 ;  i < label_names . Length ;  i ++ ) { binaryWriter . Write ( label_names [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( label_names [ i ] ) ) ;  }
            binaryWriter.Write(label_proba.Length); for  ( int  i  =  0 ;  i < label_proba . Length ;  i ++ ) binaryWriter . Write ( label_proba [ i ] ) ; 
            binaryWriter.Write(probabilities.Length); for  ( int  i  =  0 ;  i < probabilities . Length ;  i ++ ) binaryWriter . Write ( probabilities [ i ] ) ; 
            binaryWriter.Write(classifier.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( classifier ) ) ; 
            binaryWriter.Write(target_names.Length); for  ( int  i  =  0 ;  i < target_names . Length ;  i ++ ) { binaryWriter . Write ( target_names [ i ] . Length ) ;  binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( target_names [ i ] ) ) ;  }
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            labels = new System.UInt32[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < labels . Length ;  i ++ ) labels [ i ]  =  binaryReader . ReadUInt32 ( ) ; 
            label_names = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < label_names . Length ;  i ++ ) label_names [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
            label_proba = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < label_proba . Length ;  i ++ ) label_proba [ i ]  =  binaryReader . ReadDouble ( ) ; 
            probabilities = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < probabilities . Length ;  i ++ ) probabilities [ i ]  =  binaryReader . ReadDouble ( ) ; 
            classifier = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            target_names = new string[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < target_names . Length ;  i ++ ) target_names [ i ]  =  System . Text . Encoding . UTF8 . GetString ( binaryReader . ReadBytes ( binaryReader . ReadInt32 ( ) ) ) ; 
        }
    }
}