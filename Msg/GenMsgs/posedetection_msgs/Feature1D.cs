namespace Roslin.Msg.posedetection_msgs
{
    [MsgInfo("posedetection_msgs/Feature1D", "4568f21f2dd0840ca2d658d4d1710f33", "Header header\nCurve1D[] lines # N, 0-indexed\nfloat32[] descriptors # N*descriptor_dim\nfloat32[] confidences # optional\nint32 descriptor_dim\n")]
    public partial class Feature1D : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Curve1D[] lines
        {
            get;
            set;
        }

        public System.Single[] descriptors
        {
            get;
            set;
        }

        public System.Single[] confidences
        {
            get;
            set;
        }

        public System.Int32 descriptor_dim
        {
            get;
            set;
        }

        public Feature1D(): base()
        {
        }

        public Feature1D(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(lines.Length); for  ( int  i  =  0 ;  i < lines . Length ;  i ++ ) lines [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(descriptors.Length); for  ( int  i  =  0 ;  i < descriptors . Length ;  i ++ ) binaryWriter . Write ( descriptors [ i ] ) ; 
            binaryWriter.Write(confidences.Length); for  ( int  i  =  0 ;  i < confidences . Length ;  i ++ ) binaryWriter . Write ( confidences [ i ] ) ; 
            binaryWriter.Write(descriptor_dim);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            lines = new Curve1D[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < lines . Length ;  i ++ ) lines [ i ]  =  new  Curve1D ( binaryReader ) ; 
            descriptors = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < descriptors . Length ;  i ++ ) descriptors [ i ]  =  binaryReader . ReadSingle ( ) ; 
            confidences = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < confidences . Length ;  i ++ ) confidences [ i ]  =  binaryReader . ReadSingle ( ) ; 
            descriptor_dim = binaryReader.ReadInt32();
        }
    }
}