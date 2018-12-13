using DataAccess.Concrete;
using DomainEntities.Concrete;
using DomainEntities.DataAccessContracts;

namespace DataAccess
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        public ProductoRepository(Context context) : base(context)
        {
        }

        public void Dispose()
        {
            
        }
    }
}
