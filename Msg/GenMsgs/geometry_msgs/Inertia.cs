namespace Roslin.Msg.geometry_msgs
{
    [MsgInfo("geometry_msgs/Inertia", "1d26e4bb6c83ff141c5cf0d883c2b0fe", @"# Mass [kg]
float64 m

# Center of mass [m]
geometry_msgs/Vector3 com

# Inertia Tensor [kg-m^2]
#     | ixx ixy ixz |
# I = | ixy iyy iyz |
#     | ixz iyz izz |
float64 ixx
float64 ixy
float64 ixz
float64 iyy
float64 iyz
float64 izz
")]
    public partial class Inertia : RosMsg
    {
        public System.Double m
        {
            get;
            set;
        }

        public geometry_msgs.Vector3 com
        {
            get;
            set;
        }

        public System.Double ixx
        {
            get;
            set;
        }

        public System.Double ixy
        {
            get;
            set;
        }

        public System.Double ixz
        {
            get;
            set;
        }

        public System.Double iyy
        {
            get;
            set;
        }

        public System.Double iyz
        {
            get;
            set;
        }

        public System.Double izz
        {
            get;
            set;
        }

        public Inertia(): base()
        {
        }

        public Inertia(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(m);
            com.Serilize(binaryWriter);
            binaryWriter.Write(ixx);
            binaryWriter.Write(ixy);
            binaryWriter.Write(ixz);
            binaryWriter.Write(iyy);
            binaryWriter.Write(iyz);
            binaryWriter.Write(izz);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            m = binaryReader.ReadDouble();
            com = new geometry_msgs.Vector3(binaryReader);
            ixx = binaryReader.ReadDouble();
            ixy = binaryReader.ReadDouble();
            ixz = binaryReader.ReadDouble();
            iyy = binaryReader.ReadDouble();
            iyz = binaryReader.ReadDouble();
            izz = binaryReader.ReadDouble();
        }
    }
}