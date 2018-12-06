using DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        public ProductoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
