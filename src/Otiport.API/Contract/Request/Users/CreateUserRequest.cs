using Otiport.API.Contract.Models;

namespace Otiport.API.Contract.Request.Users
{
    public class CreateUserRequest : RequestBase
    {
        public UserModel UserModel { get; set; }
    }
}