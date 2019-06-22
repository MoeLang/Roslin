namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/ODEJointProperties", "1b744c32a920af979f53afe2f9c3511f", "# access to low level joint properties, change these at your own risk\nfloat64[] damping             # joint damping\nfloat64[] hiStop              # joint limit\nfloat64[] loStop              # joint limit\nfloat64[] erp                 # set joint erp\nfloat64[] cfm                 # set joint cfm\nfloat64[] stop_erp            # set joint erp for joint limit \"contact\" joint\nfloat64[] stop_cfm            # set joint cfm for joint limit \"contact\" joint\nfloat64[] fudge_factor        # joint fudge_factor applied at limits, see ODE manual for info.\nfloat64[] fmax                # ode joint param fmax\nfloat64[] vel                 # ode joint param vel\n")]
    public partial class ODEJointProperties : RosMsg
    {
        public System.Double[] damping
        {
            get;
            set;
        }

        public System.Double[] hiStop
        {
            get;
            set;
        }

        public System.Double[] loStop
        {
            get;
            set;
        }

        public System.Double[] erp
        {
            get;
            set;
        }

        public System.Double[] cfm
        {
            get;
            set;
        }

        public System.Double[] stop_erp
        {
            get;
            set;
        }

        public System.Double[] stop_cfm
        {
            get;
            set;
        }

        public System.Double[] fudge_factor
        {
            get;
            set;
        }

        public System.Double[] fmax
        {
            get;
            set;
        }

        public System.Double[] vel
        {
            get;
            set;
        }

        public ODEJointProperties(): base()
        {
        }

        public ODEJointProperties(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(damping.Length); for  ( int  i  =  0 ;  i < damping . Length ;  i ++ ) binaryWriter . Write ( damping [ i ] ) ; 
            binaryWriter.Write(hiStop.Length); for  ( int  i  =  0 ;  i < hiStop . Length ;  i ++ ) binaryWriter . Write ( hiStop [ i ] ) ; 
            binaryWriter.Write(loStop.Length); for  ( int  i  =  0 ;  i < loStop . Length ;  i ++ ) binaryWriter . Write ( loStop [ i ] ) ; 
            binaryWriter.Write(erp.Length); for  ( int  i  =  0 ;  i < erp . Length ;  i ++ ) binaryWriter . Write ( erp [ i ] ) ; 
            binaryWriter.Write(cfm.Length); for  ( int  i  =  0 ;  i < cfm . Length ;  i ++ ) binaryWriter . Write ( cfm [ i ] ) ; 
            binaryWriter.Write(stop_erp.Length); for  ( int  i  =  0 ;  i < stop_erp . Length ;  i ++ ) binaryWriter . Write ( stop_erp [ i ] ) ; 
            binaryWriter.Write(stop_cfm.Length); for  ( int  i  =  0 ;  i < stop_cfm . Length ;  i ++ ) binaryWriter . Write ( stop_cfm [ i ] ) ; 
            binaryWriter.Write(fudge_factor.Length); for  ( int  i  =  0 ;  i < fudge_factor . Length ;  i ++ ) binaryWriter . Write ( fudge_factor [ i ] ) ; 
            binaryWriter.Write(fmax.Length); for  ( int  i  =  0 ;  i < fmax . Length ;  i ++ ) binaryWriter . Write ( fmax [ i ] ) ; 
            binaryWriter.Write(vel.Length); for  ( int  i  =  0 ;  i < vel . Length ;  i ++ ) binaryWriter . Write ( vel [ i ] ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            damping = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < damping . Length ;  i ++ ) damping [ i ]  =  binaryReader . ReadDouble ( ) ; 
            hiStop = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < hiStop . Length ;  i ++ ) hiStop [ i ]  =  binaryReader . ReadDouble ( ) ; 
            loStop = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < loStop . Length ;  i ++ ) loStop [ i ]  =  binaryReader . ReadDouble ( ) ; 
            erp = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < erp . Length ;  i ++ ) erp [ i ]  =  binaryReader . ReadDouble ( ) ; 
            cfm = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < cfm . Length ;  i ++ ) cfm [ i ]  =  binaryReader . ReadDouble ( ) ; 
            stop_erp = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < stop_erp . Length ;  i ++ ) stop_erp [ i ]  =  binaryReader . ReadDouble ( ) ; 
            stop_cfm = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < stop_cfm . Length ;  i ++ ) stop_cfm [ i ]  =  binaryReader . ReadDouble ( ) ; 
            fudge_factor = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < fudge_factor . Length ;  i ++ ) fudge_factor [ i ]  =  binaryReader . ReadDouble ( ) ; 
            fmax = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < fmax . Length ;  i ++ ) fmax [ i ]  =  binaryReader . ReadDouble ( ) ; 
            vel = new System.Double[binaryReader.ReadInt32()]; for  ( int  i  =  0 ;  i < vel . Length ;  i ++ ) vel [ i ]  =  binaryReader . ReadDouble ( ) ; 
        }
    }
}