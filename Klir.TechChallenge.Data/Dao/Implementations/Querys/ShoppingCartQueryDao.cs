using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klir.TechChallenge.Data.Context;
using Klir.TechChallenge.Data.Dao.Definitions.Querys;
using Klir.TechChallenge.Data.Dao.Implementations.Repository;
using Klir.TechChallenge.Domain.Entities;

namespace Klir.TechChallenge.Data.Dao.Implementations.Querys
{
    internal class ShoppingCartQueryDao : QueryRepository<ShoppingCart>, IShoppingCartQueryDao
    {
        public ShoppingCartQueryDao(IKlirContext pragmaticContext) : base(pragmaticContext)
        {
        }
    }
}
