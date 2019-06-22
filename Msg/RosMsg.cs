using System.IO;

namespace Roslin.Msg
{
    public abstract class RosMsg
    {
        public static string Type { get; }
        public static string MD5Sum { get; }
        public static string Text { get; }
        public RosMsg() { }
        public RosMsg(BinaryReader binaryReader) => Deserilize(binaryReader);
        public abstract void Deserilize(BinaryReader binaryReader);
        public abstract void Serilize(BinaryWriter binaryWriter);
    }
}