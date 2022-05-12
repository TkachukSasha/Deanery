using Deanery.Application.Common.Pagination.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deanery.Application.Common.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Create(TEntity obj);
        Task Update(TEntity obj);
        Task Delete(string id);
        Task<TEntity> Get(string id);
        Task<IEnumerable<TEntity>> GetAll(PaginationFilter pagination);
    }
}
