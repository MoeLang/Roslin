using System.Linq;

namespace Roslin.Msg
{
    public static class MsgInfo
    {
        public static string MsgType<T>() where T : RosMsg => (typeof(T).GetCustomAttributes(typeof(MsgInfoAttribute), false).FirstOrDefault() as MsgInfoAttribute)?.Type;
        public static string MsgMd5<T>() where T : RosMsg => (typeof(T).GetCustomAttributes(typeof(MsgInfoAttribute), false).FirstOrDefault() as MsgInfoAttribute)?.Md5;
        public static string MsgDef<T>() where T : RosMsg => (typeof(T).GetCustomAttributes(typeof(MsgInfoAttribute), false).FirstOrDefault() as MsgInfoAttribute)?.Definition;
    }
}