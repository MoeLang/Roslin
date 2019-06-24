namespace Roslin.Msg.jsk_recognition_msgs
{
    [MsgInfo("jsk_recognition_msgs/LabelArray", "8cdb9aed89bee725ff5ad76b2986927d", @"Header header
Label[] labels
")]
    public partial class LabelArray : RosMsg
    {
        public std_msgs.Header header
        {
            get;
            set;
        }

        public Label[] labels
        {
            get;
            set;
        }

        public LabelArray(): base()
        {
        }

        public LabelArray(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            header.Serilize(binaryWriter);
            binaryWriter.Write(labels.Length); for  ( int  i  =  0 ;  i < labels . Length ;  i ++ ) labels [ i ] . Serilize ( binaryWriter ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            header = new std_msgs.Header(binaryReader);
            labels = new Label[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < labels . Length ;  i ++ ) labels [ i ]  =  new  Label ( binaryReader ) ; 
        }
    }
}