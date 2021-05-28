

using System;
using System.Linq;
using System.Linq.Expressions;
using Klir.TechChallenge.Data.Context;
using Klir.TechChallenge.Data.Dao.Definitions.Repository;
using Microsoft.EntityFrameworkCore;

namespace Klir.TechChallenge.Data.Dao.Implementations.Repository
{
    public class QueryRepository <T>: IDisposable, IQueryRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        public QueryRepository(IKlirContext dbContext)
        {
            _dbContext = dbContext as DbContext;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
    }
}
