using DomainEntities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class Context : DbContext
    {        
        DbSet<Producto> Productos {get; set;}

        public Context(DbContextOptions<Context> options)
            :base(options)
        {
        }

        
    }
}
