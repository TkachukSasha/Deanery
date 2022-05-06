using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deanery.Application.Common.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(string id);
        Task<TEntity> Get(string id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
