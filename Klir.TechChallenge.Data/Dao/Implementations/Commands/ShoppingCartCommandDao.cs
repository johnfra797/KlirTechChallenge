

using Klir.TechChallenge.Data.Context;
using Klir.TechChallenge.Data.Dao.Definitions.Commands;
using Klir.TechChallenge.Data.Dao.Implementations.Repository;
using Klir.TechChallenge.Domain.Entities;

namespace Klir.TechChallenge.Data.Dao.Implementations.Commands
{
    internal class ShoppingCartCommandDao : CommandRepository<ShoppingCart>, IShoppingCartCommandDao
    {
        public ShoppingCartCommandDao(IKlirContext pragmaticContext) : base(pragmaticContext)
        {
        }

    }
}
