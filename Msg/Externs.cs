using System;
using System.IO;

namespace Roslin.Msg
{
    public static class Externs
    {
        public static void Write(this BinaryWriter binaryWriter, DateTime dateTime)
        {
            var time = (dateTime - new DateTime(1970, 1, 1)).TotalSeconds;
            uint sec = (uint)time;
            uint nsec = (uint)(1000000000 * (time - sec));
            binaryWriter.Write(sec);
            binaryWriter.Write(nsec);
        }
        public static void Write(this BinaryWriter binaryWriter, TimeSpan timeSpan)
        {
            var time = timeSpan.TotalSeconds;
            uint sec = (uint)time;
            uint nsec = (uint)(1000000000 * (time - sec));
            binaryWriter.Write(sec);
            binaryWriter.Write(nsec);
        }
        public static DateTime ReadDateTime(this BinaryReader binaryReader)
        {
            var sec = binaryReader.ReadUInt32();
            var nsec = binaryReader.ReadUInt32();
            return new DateTime(1970, 1, 1).AddSeconds(sec + ((double)nsec / 1000000000));
        }
        public static TimeSpan ReadTimeSpan(this BinaryReader binaryReader)
        {
            var sec = binaryReader.ReadInt32();
            var nsec = binaryReader.ReadInt32();
            return TimeSpan.FromSeconds(sec + ((double)nsec / 1000000000));
        }
    }
}
