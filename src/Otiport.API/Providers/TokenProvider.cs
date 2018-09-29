using System;
using System.Threading.Tasks;

namespace Otiport.API.Providers
{
    public class TokenProvider : ITokenProvider
    {
        public Task<string> GenerateTokenAsync(Guid userEntityId, string emailAddress, int userGroupId)
        {
            //TODO (peacecwz): Implement JWT token provider
            return Task.FromResult("");
        }
    }
}