using Spa.Models;
using System.Threading.Tasks;

namespace Spa
{
    public interface IQueryHandler<M, C> where M : class where C : class
    {
        Task<IEnumerable<M>> GetAll();
        Task<Permission> GetOne(C query);
    }
}

