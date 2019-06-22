namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/PlotData", "abc388ba2207b305f8695ad025452af4", "uint32 SCATTER=1\nuint32 LINE=2\n\nHeader header\nfloat32[] xs\nfloat32[] ys\nuint32 type                     #SCATTER or LINE\nstring label\nbool fit_line\nbool fit_line_ransac\n")]
    public partial class PlotData : RosMsg
    {
        public System.UInt32 SCATTER => 1;
        public System.UInt32 LINE => 2;
        public std_msgs.Header header
        {
            get;
            set;
        }

        public System.Single[] xs
        {
            get;
            set;
        }

        public System.Single[] ys
        {
            get;
            set;
        }

        public System.UInt32 type
        {
            get;
            set;
        }

        public System.String label
        {
            get;
            set;
        }

        public System.Boolean fit_line
        {
            get;
            set;
        }

        public System.Boolean fit_line_ransac
        {
            get;
            set;
        }

        public PlotData(): base()
        {
        }

        public PlotData(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(xs.Length); for  ( int  i  =  0 ;  i < xs . Length ;  i ++ ) binaryWriter . Write ( xs [ i ] ) ; 
            binaryWriter.Write(ys.Length); for  ( int  i  =  0 ;  i < ys . Length ;  i ++ ) binaryWriter . Write ( ys [ i ] ) ; 
            binaryWriter.Write(type);
            binaryWriter.Write(label.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( label ) ) ; 
            binaryWriter.Write(fit_line);
            binaryWriter.Write(fit_line_ransac);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            xs = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < xs . Length ;  i ++ ) xs [ i ]  =  binaryReader . ReadSingle ( ) ; 
            ys = new System.Single[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < ys . Length ;  i ++ ) ys [ i ]  =  binaryReader . ReadSingle ( ) ; 
            type = binaryReader.ReadUInt32();
            label = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            fit_line = binaryReader.ReadBoolean();
            fit_line_ransac = binaryReader.ReadBoolean();
        }
    }
}