namespace Roslin.Msg.turtle_actionlib
{
    [MsgInfo("turtle_actionlib/ShapeResult", "b06c6e2225f820dbc644270387cd1a7c", @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
#result definition
float32 interior_angle
float32 apothem
")]
    public partial class ShapeResult : RosMsg
    {
        public System.Single interior_angle
        {
            get;
            set;
        }

        public System.Single apothem
        {
            get;
            set;
        }

        public ShapeResult(): base()
        {
        }

        public ShapeResult(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(interior_angle);
            binaryWriter.Write(apothem);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            interior_angle = binaryReader.ReadSingle();
            apothem = binaryReader.ReadSingle();
        }
    }
}