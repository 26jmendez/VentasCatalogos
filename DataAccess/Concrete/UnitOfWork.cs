using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context context;

        public UnitOfWork(Context dbContext)
        {
            context = dbContext;
        }

        public Context Context
        {
            get
            {
                return context;
            }
        }

        public void Completar()
        {
            context.SaveChanges();
        }
        
        public void Dispose()
        {
        }
    }
}
