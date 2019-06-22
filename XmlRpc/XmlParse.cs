using System;
using System.IO;
using System.Xml;

namespace Roslin.XmlRpc
{
    internal static class XmlParse
    {
        const string METHOD_CALL = "methodCall";
        const string METHOD_RESPONSE = "methodResponse";
        const string METHOD_NAME = "methodName";
        const string PARAMS = "params";
        const string PARAM = "param";
        const string VALUE = "value";
        const string ARRAY = "array";
        const string DATA = "data";
        const string INT = "int";
        const string I4 = "i4";
        const string BOOLEAN = "boolean";
        const string STRING = "string";
        const string STEXT = "#text";
        public static XmlDocument RequestRemote(string methodName, params object[] vs)
        {
            XmlDocument doc = new XmlDocument() { PreserveWhitespace = true };
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.SetMethodName(methodName).SetParams(vs);
            return doc;
        }
        public static MemoryStream RequestRemoteStream(string methodName, params object[] vs)
        {
            MemoryStream memoryStream = new MemoryStream();
            RequestRemote(methodName, vs).Save(memoryStream);
            memoryStream.Position = 0;
            return memoryStream;
        }
        public static object[] RemoteResponseStream(Stream stream)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);
            var nodeList = doc.GetElementsByTagName(PARAMS);
            if (nodeList != null && nodeList[0] != null)
            {
                object[] ret = new object[nodeList[0].ChildNodes.Count];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = GetParam(nodeList[0].ChildNodes[i]);
                }
                return ret;
            }
            return null;
        }
        public static string RemoteRequestStream(this Stream stream, out object[] vs)
        {
            vs = null;
            string methodName = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);
            var nodeMethodName = doc.GetElementsByTagName(METHOD_NAME);
            if (nodeMethodName != null && nodeMethodName[0] != null)
            {
                methodName = nodeMethodName[0].InnerText;
            }
            var nodeList = doc.GetElementsByTagName(PARAMS);
            if (nodeList != null && nodeList[0] != null)
            {
                vs = new object[nodeList[0].ChildNodes.Count];
                for (int i = 0; i < vs.Length; i++)
                {
                    vs[i] = GetParam(nodeList[0].ChildNodes[i]);
                }
            }
            return methodName;
        }
        public static void ResponseRemoteStream(this Stream stream, params object[] vs)
        {
            XmlDocument doc = new XmlDocument() { PreserveWhitespace = true };
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AddMethodResponse().SetParams(vs);
            doc.Save(stream);
        }
        private static object GetParam(XmlNode xmlNode)
        {
            XmlNode value;
            if (xmlNode != null && xmlNode.Name == VALUE)
                value = xmlNode;
            else
                value = xmlNode[VALUE];
            if (value != null && value.FirstChild != null)
            {
                switch (value.FirstChild.Name)
                {
                    case ARRAY:
                        object[] ret = new object[value.FirstChild[DATA].ChildNodes.Count];
                        for (int i = 0; i < ret.Length; i++)
                        {
                            ret[i] = GetParam(value.FirstChild[DATA].ChildNodes[i]);
                        }
                        return ret;
                    case INT:
                    case I4:
                        return int.Parse(value.FirstChild.InnerText);
                    case BOOLEAN:
                        if (value.FirstChild.InnerText != null)
                        {
                            if (value.FirstChild.InnerText == "1")
                            {
                                return true;
                            }
                            else
                            {
                                return bool.Parse(value.FirstChild.InnerText);
                            }
                        }
                        return false;
                    case STRING:
                    case STEXT:
                        return value.FirstChild.InnerText;
                    default:
                        throw new Exception($"Unknown value type {value.FirstChild.Name}");
                }
            }
            return null;
        }
        private static XmlDocument AddMethodCall(this XmlDocument xmlDocument, out XmlElement methodCallElement)
        {
            methodCallElement = xmlDocument.GetElementById(METHOD_CALL);
            if (methodCallElement == null)
            {
                methodCallElement = xmlDocument.CreateElement(METHOD_CALL);
                xmlDocument.AppendChild(methodCallElement);
            }
            return xmlDocument;
        }
        private static XmlDocument AddMethodResponse(this XmlDocument xmlDocument)
        {
            var methodResponseElement = xmlDocument.GetElementById(METHOD_RESPONSE);
            if (methodResponseElement == null)
            {
                methodResponseElement = xmlDocument.CreateElement(METHOD_RESPONSE);
                xmlDocument.AppendChild(methodResponseElement);
            }
            return xmlDocument;
        }
        private static XmlDocument SetMethodName(this XmlDocument xmlDocument, string methodName)
        {
            XmlElement methodCallElement = xmlDocument.DocumentElement;
            if (methodCallElement == null)
            {
                xmlDocument.AddMethodCall(out methodCallElement);
            }
            XmlElement methodNameElement = xmlDocument.GetElementById(METHOD_NAME);
            if (methodNameElement == null)
            {
                methodNameElement = xmlDocument.CreateElement(METHOD_NAME);
                methodCallElement.AppendChild(methodNameElement);
            }
            methodNameElement.InnerText = methodName;
            return xmlDocument;
        }
        private static XmlDocument SetParams(this XmlDocument xmlDocument, params object[] vs)
        {
            XmlElement rootElement = xmlDocument.DocumentElement;
            if (rootElement == null)
            {
                throw new Exception("root xml element is null");
            }
            XmlElement paramsElement = xmlDocument.GetElementById(PARAMS);
            if (paramsElement == null)
            {
                paramsElement = xmlDocument.CreateElement(PARAMS);
                rootElement.AppendChild(paramsElement);
            }
            foreach (var v in vs)
            {
                paramsElement.AppendParam(xmlDocument, v);
            }
            return xmlDocument;
        }
        private static void AppendParam(this XmlElement paramsElement, XmlDocument xmlDocument, object v)
        {
            if (v != null)
            {
                paramsElement.AppendChild(xmlDocument.CreateElement(PARAM).AppendValue(xmlDocument, v));
            }
        }
        private static XmlElement AppendValue(this XmlElement targetElement, XmlDocument xmlDocument, object[] vs)
        {
            foreach (var v in vs)
            {
                targetElement.AppendValue(xmlDocument, v);
            }
            return targetElement;
        }
        private static XmlElement AppendValue(this XmlElement targetElement, XmlDocument xmlDocument, object v)
        {
            XmlElement valueElement = xmlDocument.CreateElement(VALUE);
            if (v is int)
            {
                XmlElement intElement = xmlDocument.CreateElement(INT);
                intElement.InnerText = v.ToString();
                valueElement.AppendChild(intElement);
            }
            else if (v is string)
            {
                XmlElement stringElement = xmlDocument.CreateElement(STRING);
                stringElement.InnerText = v.ToString();
                valueElement.AppendChild(stringElement);
            }
            else if (v is Array)
            {
                XmlElement arrayElement = xmlDocument.CreateElement(ARRAY);
                XmlElement dataElement = xmlDocument.CreateElement(DATA);
                dataElement.AppendValue(xmlDocument, v as object[]);
                arrayElement.AppendChild(dataElement);
                valueElement.AppendChild(arrayElement);
            }
            targetElement.AppendChild(valueElement);
            return targetElement;
        }
    }
}