using System;

namespace Roslin.Msg
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class MsgInfoAttribute : Attribute
    {
        public MsgInfoAttribute(string type, string md5, string def = null)
        {
            Type = type;
            Md5 = md5;
            Definition = def;
        }
        public string Type { get; private set; }
        public string Md5 { get; private set; }
        public string Definition { get; private set; }
    }
}