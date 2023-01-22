using Spa.Data;
using Spa.Models;

namespace Spa.Services
{
    public class UserRoleRepository: GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
