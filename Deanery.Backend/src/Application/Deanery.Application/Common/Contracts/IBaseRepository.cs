using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deanery.Application.Common.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Create(TEntity obj);
        bool Update(TEntity obj);
        bool Delete(string id);
        Task<TEntity> Get(string id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
