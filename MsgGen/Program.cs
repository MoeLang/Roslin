using System.IO;

namespace Roslin.MsgGen
{
    class Program
    {
        static void Main(string[] _)
        {
            new MsgGenerator(Directory.GetCurrentDirectory()).GenerateCodeToPath(Path.Combine(Directory.GetCurrentDirectory(), "GenMsgs"));
        }
    }
}