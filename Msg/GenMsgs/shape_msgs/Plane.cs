namespace Roslin.Msg.shape_msgs
{
    [MsgInfo("shape_msgs/Plane", "2c1b92ed8f31492f8e73f6a4a44ca796", "# Representation of a plane, using the plane equation ax + by + cz + d = 0\n\n# a := coef[0]\n# b := coef[1]\n# c := coef[2]\n# d := coef[3]\n\nfloat64[4] coef\n")]
    public partial class Plane : RosMsg
    {
        public System.Double[] coef
        {
            get;
            set;
        }

        public Plane(): base()
        {
        }

        public Plane(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            for (int i = 0; i < 4; i++)
                binaryWriter.Write(coef[i]);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            coef = new System.Double[4]; for  ( int  i  =  0 ;  i < 4 ;  i ++ ) coef [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}