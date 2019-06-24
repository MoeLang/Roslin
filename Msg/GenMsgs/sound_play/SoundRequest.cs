namespace Roslin.Msg.sound_play
{
    [MsgInfo("sound_play/SoundRequest", "d098ce4a040686259137ece23a625167", @"# IMPORTANT: You should never have to generate this message yourself.
# Use the sound_play::SoundClient C++ helper or the
# sound_play.libsoundplay.SoundClient Python helper.

# Sounds
int8 BACKINGUP = 1
int8 NEEDS_UNPLUGGING = 2
int8 NEEDS_PLUGGING = 3
int8 NEEDS_UNPLUGGING_BADLY = 4
int8 NEEDS_PLUGGING_BADLY = 5

# Sound identifiers that have special meaning
int8 ALL = -1 # Only legal with PLAY_STOP
int8 PLAY_FILE = -2
int8 SAY = -3

int8 sound # Selects which sound to play (see above)

# Commands
int8 PLAY_STOP = 0 # Stop this sound from playing
int8 PLAY_ONCE = 1 # Play the sound once
int8 PLAY_START = 2 # Play the sound in a loop until a stop request occurs

int8 command # Indicates what to do with the sound

# Volume at which to play the sound, with 0 as mute and 1.0 as 100%.
float32 volume

string arg # file name or text to say
string arg2 # other arguments
")]
    public partial class SoundRequest : RosMsg
    {
        public System.SByte BACKINGUP => 1;
        public System.SByte NEEDS_UNPLUGGING => 2;
        public System.SByte NEEDS_PLUGGING => 3;
        public System.SByte NEEDS_UNPLUGGING_BADLY => 4;
        public System.SByte NEEDS_PLUGGING_BADLY => 5;
        public System.SByte ALL => -1;
        public System.SByte PLAY_FILE => -2;
        public System.SByte SAY => -3;
        public System.SByte PLAY_STOP => 0;
        public System.SByte PLAY_ONCE => 1;
        public System.SByte PLAY_START => 2;
        public System.SByte sound
        {
            get;
            set;
        }

        public System.SByte command
        {
            get;
            set;
        }

        public System.Single volume
        {
            get;
            set;
        }

        public System.String arg
        {
            get;
            set;
        }

        public System.String arg2
        {
            get;
            set;
        }

        public SoundRequest(): base()
        {
        }

        public SoundRequest(System.IO.BinaryReader binaryReader): base(binaryReader)
        {
        }

        public override void Serilize(System.IO.BinaryWriter binaryWriter)
        {
            binaryWriter.Write(sound);
            binaryWriter.Write(command);
            binaryWriter.Write(volume);
            binaryWriter.Write(arg.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( arg ) ) ; 
            binaryWriter.Write(arg2.Length); binaryWriter . Write ( System . Text . Encoding . UTF8 . GetBytes ( arg2 ) ) ; 
        }

        public override void Deserilize(System.IO.BinaryReader binaryReader)
        {
            sound = binaryReader.ReadSByte();
            command = binaryReader.ReadSByte();
            volume = binaryReader.ReadSingle();
            arg = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
            arg2 = System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
        }
    }
}