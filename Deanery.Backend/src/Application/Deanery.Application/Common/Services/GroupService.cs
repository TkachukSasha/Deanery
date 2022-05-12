using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;

namespace Deanery.Application.Common.Services
{
    public class GroupService : BaseService<Group>, IGroupRepository
    {
        public GroupService(IDeaneryDbContext context) : base(context)
        {
        }
    }
}
