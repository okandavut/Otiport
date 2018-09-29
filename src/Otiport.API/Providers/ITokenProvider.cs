using System;
using System.Threading.Tasks;

namespace Otiport.API.Providers
{
    public interface ITokenProvider
    {
        Task<string> GenerateTokenAsync(Guid userEntityId, string emailAddress, int userGroupId);
    }
}