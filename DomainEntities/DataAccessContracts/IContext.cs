using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntities.DataAccessContracts
{
    public interface IContext
    {
        int SaveChanges();
        //DbSet<TEntity> Set<TEntity>();
    }
}
