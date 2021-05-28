using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klir.TechChallenge.Data.Dao.Definitions.Repository;
using Klir.TechChallenge.Domain.Entities;

namespace Klir.TechChallenge.Data.Dao.Definitions.Commands
{
  public interface IProductCommandDao : ICommandRepository<Product>
    {

    }
}
