using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Data.Dao.Definitions.Repository
{
    public interface ICommandRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
      
    }
}
