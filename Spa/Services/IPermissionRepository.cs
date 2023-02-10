using Spa.Models;

namespace Spa.Services
{
    public interface IPermissionRepository : IGenericRepository<Permission>
    {
        Task<Permission> GetById(int id);
    }
}
