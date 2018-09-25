using System;
using System.Threading.Tasks;

namespace Otiport.API.Repositories
{
    public interface IRepository : IDisposable
    {
        Task<bool> SaveAsync();
    }
}
