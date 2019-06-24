namespace Roslin.Msg.gazebo_msgs
{
    [MsgInfo("gazebo_msgs/ODEPhysics", "667d56ddbd547918c32d1934503dc335", @"bool auto_disable_bodies           # enable auto disabling of bodies, default false
uint32 sor_pgs_precon_iters        # preconditioning inner iterations when uisng projected Gauss Seidel
uint32 sor_pgs_iters               # inner iterations when uisng projected Gauss Seidel
float64 sor_pgs_w                  # relaxation parameter when using projected Gauss Seidel, 1 = no relaxation
float64 sor_pgs_rms_error_tol      # rms error tolerance before stopping inner iterations
float64 contact_surface_layer      # contact ""dead-band"" width
float64 contact_max_correcting_vel # contact maximum correction velocity
float64 cfm                        # global constraint force mixing
float64 erp                        # global error reduction parameter
uint32 max_contacts                # maximum contact joints between two geoms
")]
    public partial class ODEPhysics : RosMsg
    {
        public System.Boolean auto_disable_bodies
        {
            get;
            set;
        }

        public System.UInt32 sor_pgs_precon_iters
        {
            get;
            set;
        }

        public System.UInt32 sor_pgs_iters
        {
            get;
            set;
        }

        public System.Double sor_pgs_w
        {
            get;
            set;
        }

        public System.Double sor_pgs_rms_error_tol
        {
            get;
            set;
        }

        public System.Double contact_surface_layer
        {
            get;
            set;
        }

        public System.Double contact_max_correcting_vel
        {
            get;
            set;
        }

        public System.Double cfm
        {
            get;
            set;
        }

        public System.Double erp
        {
            get;
            set;
        }

        public System.UInt32 max_contacts
        {
            get;
            set;
        }

        public ODEPhysics(): base()
        {
        }

        public ODEPhysics(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(auto_disable_bodies);
            binaryWriter.Write(sor_pgs_precon_iters);
            binaryWriter.Write(sor_pgs_iters);
            binaryWriter.Write(sor_pgs_w);
            binaryWriter.Write(sor_pgs_rms_error_tol);
            binaryWriter.Write(contact_surface_layer);
            binaryWriter.Write(contact_max_correcting_vel);
            binaryWriter.Write(cfm);
            binaryWriter.Write(erp);
            binaryWriter.Write(max_contacts);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            auto_disable_bodies = binaryReader.ReadBoolean();
            sor_pgs_precon_iters = binaryReader.ReadUInt32();
            sor_pgs_iters = binaryReader.ReadUInt32();
            sor_pgs_w = binaryReader.ReadDouble();
            sor_pgs_rms_error_tol = binaryReader.ReadDouble();
            contact_surface_layer = binaryReader.ReadDouble();
            contact_max_correcting_vel = binaryReader.ReadDouble();
            cfm = binaryReader.ReadDouble();
            erp = binaryReader.ReadDouble();
            max_contacts = binaryReader.ReadUInt32();
        }
    }
}