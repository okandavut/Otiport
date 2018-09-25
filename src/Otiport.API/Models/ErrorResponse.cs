namespace Otiport.API.Models
{
    public class ErrorResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public List<Error> Errors { get; set; } = new List<Error>();
    }
}
