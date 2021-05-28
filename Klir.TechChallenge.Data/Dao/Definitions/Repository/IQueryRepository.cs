using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Klir.TechChallenge.Data.Dao.Definitions.Repository
{
    public interface IQueryRepository<T>
    {
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
    }
}
