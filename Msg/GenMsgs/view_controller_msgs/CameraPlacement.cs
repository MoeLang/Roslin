namespace Roslin.Msg.view_controller_msgs
{
    [MsgInfo("view_controller_msgs/CameraPlacement", "38be6efe15caa86e2c835dd05ab88393", "# The interpolation mode to use during this step\nuint8 interpolation_mode\nuint8 LINEAR    = 0 # Positions will be linearly interpolated\nuint8 SPHERICAL = 1 # Position and orientation will be interpolated in a spherical sense.\n\n# Sets this as the camera attached (fixed) frame before movement.\n# An empty string will leave the attached frame unchanged. \nstring target_frame\n\n# When should this pose be reached?\n# A negative value will disable the pose command altogether.\nduration time_from_start\n\n# The frame-relative point for the camera.\ngeometry_msgs/PointStamped eye\n\n# The frame-relative point for the focus (or pivot for an Orbit controller).\ngeometry_msgs/PointStamped focus\n\n# The frame-relative vector that maps to \"up\" in the view plane.\n# The zero-vector will default to +Z in the view controller's \"Target Frame\".\ngeometry_msgs/Vector3Stamped up\n\n# ------------------------------------------------\n# Some paramters for interaction control\n# ------------------------------------------------\n# The interaction style that should be activated when movement is done.\nuint8 mouse_interaction_mode\nuint8 NO_CHANGE = 0 # Leaves the control style unchanged\nuint8 ORBIT = 1 # Activates the Orbit-style controller\nuint8 FPS   = 2 # Activates the FPS-style controller\n\n# A flag to enable or disable user interaction \n# (defaults to false so that interaction is enabled)\nbool interaction_disabled\n\n# A flag indicating if the camera yaw axis is fixed to +Z of the camera attached_frame\nbool allow_free_yaw_axis\n")]
    public partial class CameraPlacement : RosMsg
    {
        public System.Byte LINEAR => 0;
        public System.Byte SPHERICAL => 1;
        public System.Byte NO_CHANGE => 0;
        public System.Byte ORBIT => 1;
        public System.Byte FPS => 2;
        public System.Byte interpolation_mode
        {
            get;
            set;
        }

        public System.String target_frame
        {
            get;
            set;
        }

        public System.TimeSpan time_from_start
        {
            get;
            set;
        }

        public geometry_msgs.PointStamped eye
        {
            get;
            set;
        }

        public geometry_msgs.PointStamped focus
        {
            get;
            set;
        }

        public geometry_msgs.Vector3Stamped up
        {
            get;
            set;
        }

        public System.Byte mouse_interaction_mode
        {
            get;
            set;
        }

        public System.Boolean interaction_disabled
        {
            get;
            set;
        }

        public System.Boolean allow_free_yaw_axis
        {
            get;
            set;
        }

        public CameraPlacement(): base()
        {
        }

        public CameraPlacement(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(interpolation_mode);
            binaryWriter.Write(target_frame.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( target_frame ) ) ; 
            binaryWriter.Write(time_from_start);
            eye.Serilize(binaryWriter);
            focus.Serilize(binaryWriter);
            up.Serilize(binaryWriter);
            binaryWriter.Write(mouse_interaction_mode);
            binaryWriter.Write(interaction_disabled);
            binaryWriter.Write(allow_free_yaw_axis);
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            interpolation_mode = binaryReader.ReadByte();
            target_frame = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            time_from_start = binaryReader.ReadTimeSpan();
            eye = new geometry_msgs.PointStamped(binaryReader);
            focus = new geometry_msgs.PointStamped(binaryReader);
            up = new geometry_msgs.Vector3Stamped(binaryReader);
            mouse_interaction_mode = binaryReader.ReadByte();
            interaction_disabled = binaryReader.ReadBoolean();
            allow_free_yaw_axis = binaryReader.ReadBoolean();
        }
    }
}