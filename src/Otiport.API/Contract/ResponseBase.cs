namespace Otiport.API.Contract
{
    public class ResponseBase
    {
        public int StatusCode { get; set; }

        public bool IsSuccess => StatusCode >= 200 && StatusCode < 400;
    }
}