using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public Context Context
        {
            get
            {
                return _context;
            }
        }

        public void Completar()
        {
            _context.SaveChanges();
        }
        
        public void Dispose()
        {
        }
    }
}
