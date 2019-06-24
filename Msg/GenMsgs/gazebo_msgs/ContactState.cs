namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/ContactState", "48c0ffb054b8c444f870cecea1ee50d9", @"string info                                   # text info on this contact
string collision1_name                        # name of contact collision1
string collision2_name                        # name of contact collision2
geometry_msgs/Wrench[] wrenches               # list of forces/torques
geometry_msgs/Wrench total_wrench             # sum of forces/torques in every DOF
geometry_msgs/Vector3[] contact_positions     # list of contact position
geometry_msgs/Vector3[] contact_normals       # list of contact normals
float64[] depths                              # list of penetration depths
")]
    public partial class ContactState : RosMsg
    {
        public System.String info
        {
            get;
            set;
        }

        public System.String collision1_name
        {
            get;
            set;
        }

        public System.String collision2_name
        {
            get;
            set;
        }

        public geometry_msgs.Wrench[] wrenches
        {
            get;
            set;
        }

        public geometry_msgs.Wrench total_wrench
        {
            get;
            set;
        }

        public geometry_msgs.Vector3[] contact_positions
        {
            get;
            set;
        }

        public geometry_msgs.Vector3[] contact_normals
        {
            get;
            set;
        }

        public System.Double[] depths
        {
            get;
            set;
        }

        public ContactState(): base()
        {
        }

        public ContactState(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(info.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( info ) ) ; 
            binaryWriter.Write(collision1_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( collision1_name ) ) ; 
            binaryWriter.Write(collision2_name.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( collision2_name ) ) ; 
            binaryWriter.Write(wrenches.Length); for  ( int  i  =  0 ;  i < wrenches . Length ;  i ++ ) wrenches [ i ] . Serilize ( binaryWriter ) ; 
            total_wrench.Serilize(binaryWriter);
            binaryWriter.Write(contact_positions.Length); for  ( int  i  =  0 ;  i < contact_positions . Length ;  i ++ ) contact_positions [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(contact_normals.Length); for  ( int  i  =  0 ;  i < contact_normals . Length ;  i ++ ) contact_normals [ i ] . Serilize ( binaryWriter ) ; 
            binaryWriter.Write(depths.Length); for  ( int  i  =  0 ;  i < depths . Length ;  i ++ ) binaryWriter . Write ( depths [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            info = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            collision1_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            collision2_name = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            wrenches = new geometry_msgs.Wrench[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < wrenches . Length ;  i ++ ) wrenches [ i ]  =  new  geometry_msgs . Wrench ( binaryReader ) ; 
            total_wrench = new geometry_msgs.Wrench(binaryReader);
            contact_positions = new geometry_msgs.Vector3[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < contact_positions . Length ;  i ++ ) contact_positions [ i ]  =  new  geometry_msgs . Vector3 ( binaryReader ) ; 
            contact_normals = new geometry_msgs.Vector3[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < contact_normals . Length ;  i ++ ) contact_normals [ i ]  =  new  geometry_msgs . Vector3 ( binaryReader ) ; 
            depths = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < depths . Length ;  i ++ ) depths [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}