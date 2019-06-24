using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Roslin.MsgGen
{
    class MsgParser
    {
        const string msgPattern = "*.msg";
        internal static Dictionary<string, string> ContentDic { get; set; } = new Dictionary<string, string>();
        internal static Dictionary<string, MsgParser> Msgs { get; set; } = new Dictionary<string, MsgParser>();
        internal static void LoadPath(string path)
        {
            ContentDic.Clear();
            Msgs.Clear();
            foreach (var file in Directory.EnumerateFiles(path, msgPattern, SearchOption.AllDirectories))
            {
                if (GetTypeFromPath(file, out _, out _, out string type))
                {
                    ContentDic.Add(type, File.ReadAllText(file));
                }
            }
            foreach (var item in ContentDic)
            {
                if (!Msgs.ContainsKey(item.Key))
                {
                    Msgs.Add(item.Key, new MsgParser(item.Key));
                }
            }
        }
        static bool GetTypeFromPath(string path, out string package, out string name, out string type)
        {
            package = type = null;
            var s = path.Split('\\');
            name = s.Last().Replace(".msg","");
            for (int i = s.Count() - 2; i > 0; i--)
            {
                if (s[i].Equals("msg"))
                {
                    continue;
                }
                else
                {
                    package = s[i];
                    break;
                }
            }
            if (name != null && package != null)
            {
                type = $"{package}/{name}";
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// msg文件中的常量定义
        /// </summary>
        public class Constant
        {
            public string Type { get; }
            public string Name { get; }
            public string Value { get; }
            public string MD5Src { get; }
            public Constant(string line)
            {
                var ls = line.Trim().Split('\t', ' ', '=', '\n').Where(_ => !string.IsNullOrEmpty(_));
                if (ls.Count() == 3)
                {
                    Type = GenType(ls.ElementAt(0), out _);
                    Name = GenName(ls.ElementAt(1));
                    Value = GenValue(Type, ls.ElementAt(2));
                    MD5Src = $"{ls.ElementAt(0)} {ls.ElementAt(1)}={ls.ElementAt(2)}\n";
                }
                else
                {
                    throw new Exception($"Const cant read msg line : {line}");
                }
            }
        }
        public class Field
        {
            public string LocalType { get; }
            public string LocalTypeWithoutArray { get; }
            public string Package { get; }
            public string Type { get; }
            public string LocalName { get; }
            public string Name { get; }
            public bool BuiltIn { get; }
            public bool Array { get; }
            public int Count { get; }
            public string MD5Src { get; }
            public string Serilize { get; }
            public string Deserilize { get; }
            public Field(MsgParser msgParser, string line)
            {
                var ls = line.Trim().Split('\t', ' ', '\n').Where(_ => !string.IsNullOrEmpty(_));
                if (ls.Count() == 2)
                {
                    Name = ls.ElementAt(1);
                    LocalName = GenName(Name);
                    if (ls.First().Contains('['))
                    {
                        var cs = ls.ElementAt(0).Split('[', ']').Where(_ => !string.IsNullOrEmpty(_));
                        if (cs.Count() > 0)
                        {
                            Array = true;
                            Type = cs.First();
                            LocalTypeWithoutArray = GenType(cs.First(), out bool builtIn);
                            LocalType = LocalTypeWithoutArray + "[]";
                            BuiltIn = builtIn;
                        }
                        else
                        {
                            throw new Exception($"Field cant read msg line : {line}");
                        }
                        if (cs.Count() > 1)
                        {
                            Count = int.Parse(cs.ElementAt(1));
                        }
                    }
                    else
                    {
                        LocalType = GenType(ls.First(), out bool builtIn);
                        Type = ls.First();
                        BuiltIn = builtIn;
                    }
                    var t = Type.Split('/').Where(_ => !string.IsNullOrEmpty(_));
                    if (t.Count() == 1)
                    {
                        if (Type == "Header")
                        {
                            Package = "std_msgs";
                        }
                        else
                        {
                            Type = t.ElementAt(0);
                            Package = msgParser.Package;
                        }
                    }
                    else if (t.Count() == 2)
                    {
                        Type = t.ElementAt(1);
                        Package = t.ElementAt(0);
                    }
                    if (BuiltIn)
                    {
                        MD5Src = $"{ls.ElementAt(0)} {ls.ElementAt(1)}\n";
                        if (Type.ToLower().Equals("string"))
                        {
                            if (Array)
                            {
                                if (Count > 0)
                                {
                                    Serilize = $"for(int i=0;i<{Count};i++)\n{{binaryWriter.Write({LocalName}[i].Length);\nbinaryWriter.Write(System.Text.Encoding.UTF8.GetBytes({LocalName}[i]));}}";
                                    Deserilize = $"{LocalName}=new string[{Count}];\nfor(int i=0;i<{Count};i++)\n{LocalName}[i]=System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));";
                                }
                                else
                                {
                                    Serilize = $"binaryWriter.Write({LocalName}.Length);\nfor(int i=0;i<{LocalName}.Length;i++)\n{{binaryWriter.Write({LocalName}[i].Length);\nbinaryWriter.Write(System.Text.Encoding.UTF8.GetBytes({LocalName}[i]));}}";
                                    Deserilize = $"{LocalName}=new string[binaryReader.ReadInt32()];\nfor(int i=0;i<{LocalName}.Length;i++)\n{LocalName}[i]=System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));";
                                }
                            }
                            else
                            {
                                Serilize = $"binaryWriter.Write({LocalName}.Length);\nbinaryWriter.Write(System.Text.Encoding.UTF8.GetBytes({LocalName}));";
                                Deserilize = $"{LocalName}=System.Text.Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));";
                            }
                        }
                        else if (Type.ToLower().Equals("byte") || Type.ToLower().Equals("uint8"))
                        {
                            if (Array)
                            {
                                if (Count > 0)
                                {
                                    Serilize = $"binaryWriter.Write({LocalName});";
                                    Deserilize = $"{LocalName}=new {LocalTypeWithoutArray}[{Count}];\n{LocalName}=binaryReader.ReadBytes({LocalName}.Length);";
                                }
                                else
                                {
                                    Serilize = $"binaryWriter.Write({LocalName}.Length);\nbinaryWriter.Write({LocalName});";
                                    Deserilize = $"{LocalName}=new {LocalTypeWithoutArray}[binaryReader.ReadInt32()];\n{LocalName}=binaryReader.ReadBytes({LocalName}.Length);";
                                }
                            }
                            else
                            {
                                Serilize = $"binaryWriter.Write({LocalName});";
                                Deserilize = $"{LocalName}={GetReadMethod(Type)};";
                            }
                        }
                        else if (Type.ToLower().Equals("char"))
                        {
                            if (Array)
                            {
                                if (Count > 0)
                                {
                                    Serilize = $"binaryWriter.Write({LocalName});";
                                    Deserilize = $"{LocalName}=new {LocalTypeWithoutArray}[{Count}];\n{LocalName}=binaryReader.ReadChars({LocalName}.Length);";
                                }
                                else
                                {
                                    Serilize = $"binaryWriter.Write({LocalName}.Length);\nbinaryWriter.Write({LocalName});";
                                    Deserilize = $"{LocalName}=new {LocalTypeWithoutArray}[binaryReader.ReadInt32()];\n{LocalName}=binaryReader.ReadChars({LocalName}.Length);";
                                }
                            }
                            else
                            {
                                Serilize = $"binaryWriter.Write({LocalName});";
                                Deserilize = $"{LocalName}={GetReadMethod(Type)};";
                            }
                        }
                        else
                        {
                            if (Array)
                            {
                                if (Count > 0)
                                {
                                    Serilize = $"for(int i=0;i<{Count};i++)\nbinaryWriter.Write({LocalName}[i]);";
                                    Deserilize = $"{LocalName}=new {LocalTypeWithoutArray}[{Count}];\nfor(int i=0;i<{Count};i++)\n{LocalName}[i]={GetReadMethod(Type)};";
                                }
                                else
                                {
                                    Serilize = $"binaryWriter.Write({LocalName}.Length);\nfor(int i=0;i<{LocalName}.Length;i++)\nbinaryWriter.Write({LocalName}[i]);";
                                    Deserilize = $"{LocalName}=new {LocalTypeWithoutArray}[binaryReader.ReadInt32()];\nfor(int i=0;i<{LocalName}.Length;i++)\n{LocalName}[i]={GetReadMethod(Type)};";
                                }
                            }
                            else
                            {
                                Serilize = $"binaryWriter.Write({LocalName});";
                                Deserilize = $"{LocalName}={GetReadMethod(Type)};";
                            }
                        }
                    }
                    else
                    {
                        var type = $"{Package}/{Type}";
                        if (!Msgs.ContainsKey(type))
                        {
                            Msgs.Add(type, new MsgParser(type));
                        }
                        MD5Src = $"{Msgs[type].MD5Sum} {Name}\n";
                        if (Array)
                        {
                            if (Count > 0)
                            {
                                Serilize = $"for(int i=0;i<{Count};i++)\n{LocalName}[i].Serilize(binaryWriter);";
                                Deserilize = $"{LocalName}=new {LocalTypeWithoutArray}[{Count}];\nfor(int i=0;i<{Count};i++)\n{LocalName}[i]=new {LocalTypeWithoutArray}(binaryReader);";
                            }
                            else
                            {
                                Serilize = $"binaryWriter.Write({LocalName}.Length);\nfor(int i=0;i<{LocalName}.Length;i++)\n{LocalName}[i].Serilize(binaryWriter);";
                                Deserilize = $"{LocalName}=new {LocalTypeWithoutArray}[binaryReader.ReadInt32()];\nfor(int i=0;i<{LocalName}.Length;i++)\n{LocalName}[i]=new {LocalTypeWithoutArray}(binaryReader);";
                            }
                        }
                        else
                        {
                            Serilize = $"{LocalName}.Serilize(binaryWriter);";
                            Deserilize = $"{LocalName}=new {LocalType}(binaryReader);";
                        }
                    }
                }
                else
                {
                    throw new Exception($"Field cant read msg line : {line}");
                }
            }

            private string GetReadMethod(string type)
            {
                switch (type.ToLower())
                {
                    case "bool":
                        return "binaryReader.ReadBoolean()";
                    case "float64":
                        return "binaryReader.ReadDouble()";
                    case "float32":
                        return "binaryReader.ReadSingle()";
                    case "uint64":
                        return "binaryReader.ReadUInt64()";
                    case "int64":
                        return "binaryReader.ReadInt64()";
                    case "uint32":
                        return "binaryReader.ReadUInt32()";
                    case "int32":
                        return "binaryReader.ReadInt32()";
                    case "uint16":
                        return "binaryReader.ReadUInt16()";
                    case "int16":
                        return "binaryReader.ReadInt16()";
                    case "uint8":
                        return "binaryReader.ReadByte()";
                    case "int8":
                        return "binaryReader.ReadSByte()";
                    case "char":
                        return "binaryReader.ReadChar()";
                    case "byte":
                        return "binaryReader.ReadByte()";
                    case "time":
                        return "binaryReader.ReadDateTime()";
                    case "duration":
                        return "binaryReader.ReadTimeSpan()";
                    default:
                        return "null";
                }
            }
        }
        public string Package { get; }
        public string Name { get; }
        public string RosType { get; }
        public string LocalType { get; }
        public bool BuiltIn { get; }
        public string MD5Sum { get; }
        public string Content { get; }
        public string[] Lines { get; }
        public List<Constant> Constants { get; } = new List<Constant>();
        public List<Field> Fields { get; } = new List<Field>();
        public MsgParser(string type)
        {
            RosType = type;
            Content = ContentDic[type];
            var s = type.Split('/');
            if (s.Count() == 2)
            {
                Package = s[0];
                Name = s[1];
            }
            else
            {
                throw new Exception($"Invalid type {type}");
            }
            LocalType = GenType(RosType, out bool builtIn);
            BuiltIn = builtIn;
            Lines = Content.Split('\n').Where(_ => !string.IsNullOrEmpty(_)).Where(_ => !_.Trim().StartsWith('#')).Select(_ => _.Split('#').FirstOrDefault().Trim()).ToArray();
            foreach (var line in Lines)
            {
                if (!string.IsNullOrEmpty(line.Trim('\t', ' ', '\n')))
                {
                    if (line.Contains('='))
                    {
                        Constants.Add(new Constant(line));
                    }
                    else
                    {
                        Fields.Add(new Field(this, line));
                    }
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Constants)
            {
                stringBuilder.Append(item.MD5Src);
            }
            foreach (var item in Fields)
            {
                stringBuilder.Append(item.MD5Src);
            }
            MD5Sum = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.Default.GetBytes(stringBuilder.ToString().TrimEnd('\n')))).Replace("-","").ToLower();
        }
        private static string GenType(string type, out bool builtIn)
        {
            switch (type.ToLower())
            {
                case "string":
                    builtIn = true;
                    return typeof(string).FullName;
                case "bool":
                    builtIn = true;
                    return typeof(bool).FullName;
                case "float64":
                    builtIn = true;
                    return typeof(double).FullName;
                case "float32":
                    builtIn = true;
                    return typeof(float).FullName;
                case "uint64":
                    builtIn = true;
                    return typeof(ulong).FullName;
                case "int64":
                    builtIn = true;
                    return typeof(long).FullName;
                case "uint32":
                    builtIn = true;
                    return typeof(uint).FullName;
                case "int32":
                    builtIn = true;
                    return typeof(int).FullName;
                case "uint16":
                    builtIn = true;
                    return typeof(ushort).FullName;
                case "int16":
                    builtIn = true;
                    return typeof(short).FullName;
                case "uint8":
                    builtIn = true;
                    return typeof(byte).FullName;
                case "int8":
                    builtIn = true;
                    return typeof(sbyte).FullName;
                case "char":
                    builtIn = true;
                    return typeof(char).FullName;
                case "byte":
                    builtIn = true;
                    return typeof(byte).FullName;
                case "time":
                    builtIn = true;
                    return typeof(DateTime).FullName;
                case "duration":
                    builtIn = true;
                    return typeof(TimeSpan).FullName;
                case "header":
                    builtIn = false;
                    return "std_msgs.Header";
                default:
                    builtIn = false;
                    return type.Replace('/', '.');
            }
        }
        private static string GenName(string name)
        {
            switch (name)
            {
                case "params":
                case "override":
                    return "@" + name;
                default:
                    return name;
            }
        }
        private static string GenValue(string type, string value)
        {
            switch (type)
            {
                case "System.String":
                    return $"\"{ value}\"";
                case "System.Single":
                case "System.Double":
                    return $"{value}f";
                default:
                    return value;
            }
        }
    }
}
