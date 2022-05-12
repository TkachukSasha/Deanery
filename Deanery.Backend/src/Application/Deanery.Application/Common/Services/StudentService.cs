using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;

namespace Deanery.Application.Common.Services
{
    public class StudentService : BaseService<Student>, IStudentRepository
    {
        public StudentService(IDeaneryDbContext context) : base(context)
        {
        }
    }
}
