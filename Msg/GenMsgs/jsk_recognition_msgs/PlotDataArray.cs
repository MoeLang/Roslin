namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/PlotDataArray", "e83e9378b374b8436f955a6cd212770a", @"Header header
jsk_recognition_msgs/PlotData[] data
bool no_legend
float32 legend_font_size
float32 max_x
float32 min_x
float32 min_y
float32 max_y
")]
    public partial class PlotDataArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public jsk_recognition_msgs.PlotData[] data
        {
            get;
            set;
        }

        public System.Boolean no_legend
        {
            get;
            set;
        }

        public System.Single legend_font_size
        {
            get;
            set;
        }

        public System.Single max_x
        {
            get;
            set;
        }

        public System.Single min_x
        {
            get;
            set;
        }

        public System.Single min_y
        {
            get;
            set;
        }

        public System.Single max_y
        {
            get;
            set;
        }

        public PlotDataArray(): base()
        {
        }

        public PlotDataArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(data.Length); for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(no_legend);
            binaryWriter.Write(legend_font_size);
            binaryWriter.Write(max_x);
            binaryWriter.Write(min_x);
            binaryWriter.Write(min_y);
            binaryWriter.Write(max_y);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            data = new jsk_recognition_msgs.PlotData[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < data . Length ;  i ++ ) data [ i ]  =  new  jsk_recognition_msgs . PlotData ( binaryReader ) ; 
            no_legend = binaryReader.ReadBoolean();
            legend_font_size = binaryReader.ReadSingle();
            max_x = binaryReader.ReadSingle();
            min_x = binaryReader.ReadSingle();
            min_y = binaryReader.ReadSingle();
            max_y = binaryReader.ReadSingle();
        }
    }
}