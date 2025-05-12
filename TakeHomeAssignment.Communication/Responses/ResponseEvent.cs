namespace TakeHomeAssignment.Communication
{
    public class ResponseEvent
    {
        public int StatusCode { get; set; }
        public object? Data { get; set; }

        public ResponseEvent(int statusCode, object? data)
        {
            StatusCode = statusCode;
            Data = data;
        }
    }
}
