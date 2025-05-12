namespace TakeHomeAssignment.Communication
{
    public class EventResult
    {
        public int StatusCode { get; set; }
        public object? Data { get; set; }

        public EventResult(int statusCode, object? data)
        {
            StatusCode = statusCode;
            Data = data;
        }
    }
}
