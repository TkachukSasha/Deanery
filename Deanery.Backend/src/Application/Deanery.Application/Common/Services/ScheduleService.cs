using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;

namespace Deanery.Application.Common.Services
{
    public class ScheduleService : BaseService<Schedule>, IScheduleRepository
    {
        public ScheduleService(IDeaneryDbContext context) : base(context)
        {
        }
    }
}
