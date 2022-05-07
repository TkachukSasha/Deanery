using Deanery.Application.Common.Contracts;
using Deanery.Application.Common.Pagination.Filters;
using MongoDB.Bson;
using MongoDB.Driver;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deanery.Application.Common.Services
{
    public abstract class BaseService<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly IDeaneryDbContext _dbContext;
        protected IMongoCollection<TEntity> _dbCollection;

        public BaseService(IDeaneryDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbCollection = _dbContext.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public async Task<TEntity> Get(string id)
        {
            var objectId = new ObjectId(id);

            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter.Eq("_id", objectId);

            return await _dbCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll(PaginationFilter pagination)
        {
            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            var all = await _dbCollection.Find(Builders<TEntity>.Filter.Empty)
                .Skip(skip)
                .Limit(pagination.PageSize)
                .ToListAsync();

            if (pagination == null)
            {
                return all;
            }

            return all;
        }

        public async Task Create(TEntity obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(typeof(TEntity).Name + " object is null");
            }
            await _dbCollection.InsertOneAsync(obj);
        }

        public virtual bool Update(TEntity obj)
        {
            if(obj == null)
            {
                return false;
            }
            _dbCollection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", obj.GetId()), obj);
            return true;
        }

        public bool Delete(string id)
        {
            var objectId = new ObjectId(id);
            var result = _dbCollection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", objectId));
            if(result == null)
            {
                return false;
            }
            return true;
        }
    }
}
