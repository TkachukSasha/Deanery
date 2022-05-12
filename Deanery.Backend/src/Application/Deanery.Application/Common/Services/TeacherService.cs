using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;

namespace Deanery.Application.Common.Services
{
    public class TeacherService : BaseService<Teacher>, ITeacherRepository
    {
        public TeacherService(IDeaneryDbContext context) : base(context)
        {
        }
    }
}
