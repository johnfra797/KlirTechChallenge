

using System;
using Klir.TechChallenge.Data.Context;
using Klir.TechChallenge.Data.Dao.Definitions.Repository;
using Microsoft.EntityFrameworkCore;

namespace Klir.TechChallenge.Data.Dao.Implementations.Repository
{

    public class CommandRepository<T> : IDisposable, ICommandRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        public CommandRepository(IKlirContext dbContext)
        {
            _dbContext = dbContext as DbContext;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Delete(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }
        public void Create(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
