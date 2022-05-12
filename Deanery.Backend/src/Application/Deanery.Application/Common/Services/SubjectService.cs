using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;

namespace Deanery.Application.Common.Services
{
    public class SubjectService : BaseService<Subject>, ISubjectRepository
    {
        public SubjectService(IDeaneryDbContext context) : base(context)
        {
        }
    }
}
