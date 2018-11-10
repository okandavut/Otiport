namespace Otiport.API.Contract
{
    public class ResponseBase
    {
        public int StatusCode { get; set; } = 200;

        public bool IsSuccess => StatusCode >= 200 && StatusCode < 400;
    }
}