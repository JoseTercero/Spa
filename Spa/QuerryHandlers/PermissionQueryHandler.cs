using Spa.Commands;
using Spa.Configuration;
using Spa.Models;
using Spa;

namespace Spa.QueryHandler
{
    public class PermissionQueryHandler : IQueryHandler<Permission, QueryByIdCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermissionQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Permission>> GetAll()
        {
            return await _unitOfWork.Permission.GetAllAsync();
        }

        public async Task<Permission> GetOne(QueryByIdCommand query)
        {
            return await _unitOfWork.Permission.GetById(query.Id);
        }
    }
}
