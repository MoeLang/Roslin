namespace Roslin.Msg.view_controller_msgs
{
    [MsgInfo("view_controller_msgs/CameraPlacement", "38be6efe15caa86e2c835dd05ab88393", @"# The interpolation mode to use during this step
uint8 interpolation_mode
uint8 LINEAR    = 0 # Positions will be linearly interpolated
uint8 SPHERICAL = 1 # Position and orientation will be interpolated in a spherical sense.

# Sets this as the camera attached (fixed) frame before movement.
# An empty string will leave the attached frame unchanged. 
string target_frame

# When should this pose be reached?
# A negative value will disable the pose command altogether.
duration time_from_start

# The frame-relative point for the camera.
geometry_msgs/PointStamped eye

# The frame-relative point for the focus (or pivot for an Orbit controller).
geometry_msgs/PointStamped focus

# The frame-relative vector that maps to ""up"" in the view plane.
# The zero-vector will default to +Z in the view controller's ""Target Frame"".
geometry_msgs/Vector3Stamped up

# ------------------------------------------------
# Some paramters for interaction control
# ------------------------------------------------
# The interaction style that should be activated when movement is done.
uint8 mouse_interaction_mode
uint8 NO_CHANGE = 0 # Leaves the control style unchanged
uint8 ORBIT = 1 # Activates the Orbit-style controller
uint8 FPS   = 2 # Activates the FPS-style controller

# A flag to enable or disable user interaction 
# (defaults to false so that interaction is enabled)
bool interaction_disabled

# A flag indicating if the camera yaw axis is fixed to +Z of the camera attached_frame
bool allow_free_yaw_axis
")]
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