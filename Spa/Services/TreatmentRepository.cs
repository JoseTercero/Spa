using Spa.Data;
using Spa.Models;

namespace Spa.Services
{
    public class TreatmentRepository: GenericRepository<Treatment>, ITreatmentRepository
    {
        public TreatmentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
