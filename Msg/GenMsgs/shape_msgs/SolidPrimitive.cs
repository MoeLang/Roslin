namespace Roslin.Msg.shape_msgs
{
    [MsgInfo("shape_msgs/SolidPrimitive", "d8f8cbc74c5ff283fca29569ccefb45d", @"# Define box, sphere, cylinder, cone 
# All shapes are defined to have their bounding boxes centered around 0,0,0.

uint8 BOX=1
uint8 SPHERE=2
uint8 CYLINDER=3
uint8 CONE=4

# The type of the shape
uint8 type


# The dimensions of the shape
float64[] dimensions

# The meaning of the shape dimensions: each constant defines the index in the 'dimensions' array

# For the BOX type, the X, Y, and Z dimensions are the length of the corresponding
# sides of the box.
uint8 BOX_X=0
uint8 BOX_Y=1
uint8 BOX_Z=2


# For the SPHERE type, only one component is used, and it gives the radius of
# the sphere.
uint8 SPHERE_RADIUS=0


# For the CYLINDER and CONE types, the center line is oriented along
# the Z axis.  Therefore the CYLINDER_HEIGHT (CONE_HEIGHT) component
# of dimensions gives the height of the cylinder (cone).  The
# CYLINDER_RADIUS (CONE_RADIUS) component of dimensions gives the
# radius of the base of the cylinder (cone).  Cone and cylinder
# primitives are defined to be circular. The tip of the cone is
# pointing up, along +Z axis.

uint8 CYLINDER_HEIGHT=0
uint8 CYLINDER_RADIUS=1

uint8 CONE_HEIGHT=0
uint8 CONE_RADIUS=1
")]
    public partial class SolidPrimitive : RosMsg
    {
        public System.Byte BOX => 1;
        public System.Byte SPHERE => 2;
        public System.Byte CYLINDER => 3;
        public System.Byte CONE => 4;
        public System.Byte BOX_X => 0;
        public System.Byte BOX_Y => 1;
        public System.Byte BOX_Z => 2;
        public System.Byte SPHERE_RADIUS => 0;
        public System.Byte CYLINDER_HEIGHT => 0;
        public System.Byte CYLINDER_RADIUS => 1;
        public System.Byte CONE_HEIGHT => 0;
        public System.Byte CONE_RADIUS => 1;
        public System.Byte type
        {
            get;
            set;
        }

        public System.Double[] dimensions
        {
            get;
            set;
        }

        public SolidPrimitive(): base()
        {
        }

        public SolidPrimitive(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(type);
            binaryWriter.Write(dimensions.Length); for  ( int  i  =  0 ;  i < dimensions . Length ;  i ++ ) binaryWriter . Write ( dimensions [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            type = binaryReader.ReadByte();
            dimensions = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < dimensions . Length ;  i ++ ) dimensions [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}