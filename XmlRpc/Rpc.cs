using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Roslin.XmlRpc
{
    public class Rpc : IDisposable
    {
        HttpListener HttpListener { get; set; }
        static Dictionary<Uri, Rpc> Rpcs { get; set; } = new Dictionary<Uri, Rpc>();
        public Dictionary<string, Func<object[], object[]>> Callbacks { get; set; } = new Dictionary<string, Func<object[], object[]>>();
        Uri Uri { get; }
        private Rpc(Uri uri)
        {
            Uri = uri;
            Rpcs.Add(uri, this);
            HttpListener = new HttpListener();
            HttpListener.Prefixes.Add(uri.ToString());
            HttpListener.Start();
            HttpListener.BeginGetContext(OnResponse, this);
        }
        public static Rpc GetRpc(Uri uri)
        {
            if (Rpcs.ContainsKey(uri))
            {
                return Rpcs[uri];
            }
            else
            {
                return new Rpc(uri);
            }
        }
        private void OnResponse(IAsyncResult ar)
        {
            if (HttpListener != null && HttpListener.IsListening)
            {
                var context = HttpListener.EndGetContext(ar);
                string methodName = context.Request.InputStream.RemoteRequestStream(out object[] vs);
                if (Callbacks.ContainsKey(methodName))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ms.ResponseRemoteStream(Callbacks[methodName].Invoke(vs));
                        context.Response.ContentLength64 = ms.Length;
                        ms.WriteTo(context.Response.OutputStream);
                    }
                }
                else
                {
                    Console.WriteLine($"Remote request {methodName}");
                }
                HttpListener.BeginGetContext(OnResponse, this);
            }
        }
        public void BindAction(string method, Func<object[], object[]> action)
        {
            if (Callbacks.ContainsKey(method))
            {
                Callbacks[method] += action;
            }
            else
            {
                Callbacks.Add(method, action);
            }
        }
        public void Dispose()
        {
            Callbacks.Clear();
            if (Rpcs.ContainsKey(Uri))
            {
                Rpcs.Remove(Uri);
            }
            if (HttpListener.IsListening)
            {
                HttpListener?.Stop();
            }
            HttpListener?.Close();
        }
        public static async Task<object[]> MethodCall(Uri uri, string methodName, params object[] vs) => XmlParse.RemoteResponseStream(await (await new HttpClient().PostAsync(uri, new StreamContent(XmlParse.RequestRemoteStream(methodName, vs)))).Content.ReadAsStreamAsync());
    }
}