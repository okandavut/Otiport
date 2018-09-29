namespace Otiport.API.Contract.Request.Users
{
    public class LoginRequest : RequestBase
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}