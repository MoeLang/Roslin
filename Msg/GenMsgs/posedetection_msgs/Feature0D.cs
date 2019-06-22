namespace Roslin.Msg.posedetection_msgs
{
    [MsgInfo("posedetection_msgs/Feature0D", "fcb3ba42a42cf972f3838cdb171f5e04", "Header header\nfloat32[] positions # 2*N, 0-indexed\nfloat32[] scales # N, optional\nfloat32[] orientations # N, optional, along +X is 0\nfloat32[] confidences\nfloat32[] descriptors # N*descriptor_dim\nint32 descriptor_dim\nstring type # type of feature\n")]
    public partial class Feature0D : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single[] positions
        {
            get;
            set;
        }

        public System.Single[] scales
        {
            get;
            set;
        }

        public System.Single[] orientations
        {
            get;
            set;
        }

        public System.Single[] confidences
        {
            get;
            set;
        }

        public System.Single[] descriptors
        {
            get;
            set;
        }

        public System.Int32 descriptor_dim
        {
            get;
            set;
        }

        public System.String type
        {
            get;
            set;
        }

        public Feature0D(): base()
        {
        }

        public Feature0D(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(positions.Length); for  ( int  i  =  0 ;  i < positions . Length ;  i ++ ) binaryWriter . Write ( positions [ i ] ) ; 
            binaryWriter.Write(scales.Length); for  ( int  i  =  0 ;  i < scales . Length ;  i ++ ) binaryWriter . Write ( scales [ i ] ) ; 
            binaryWriter.Write(orientations.Length); for  ( int  i  =  0 ;  i < orientations . Length ;  i ++ ) binaryWriter . Write ( orientations [ i ] ) ; 
            binaryWriter.Write(confidences.Length); for  ( int  i  =  0 ;  i < confidences . Length ;  i ++ ) binaryWriter . Write ( confidences [ i ] ) ; 
            binaryWriter.Write(descriptors.Length); for  ( int  i  =  0 ;  i < descriptors . Length ;  i ++ ) binaryWriter . Write ( descriptors [ i ] ) ; 
            binaryWriter.Write(descriptor_dim);
            binaryWriter.Write(type.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( type ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            positions = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < positions . Length ;  i ++ ) positions [ i ]  =  binaryReader . ReadSingle ( ) ; 
            scales = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < scales . Length ;  i ++ ) scales [ i ]  =  binaryReader . ReadSingle ( ) ; 
            orientations = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < orientations . Length ;  i ++ ) orientations [ i ]  =  binaryReader . ReadSingle ( ) ; 
            confidences = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < confidences . Length ;  i ++ ) confidences [ i ]  =  binaryReader . ReadSingle ( ) ; 
            descriptors = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < descriptors . Length ;  i ++ ) descriptors [ i ]  =  binaryReader . ReadSingle ( ) ; 
            descriptor_dim = binaryReader.ReadInt32();
            type = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}