namespace Roslin.Api
{
    public class ResponsePublisherUpdate : Response
    {
        public ResponsePublisherUpdate(int code, string status) : base(code, status) { }
        public object[] ToObj() => new object[] { Code, StatusMessage };
    }
}