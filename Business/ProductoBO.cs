using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ProductoBO : IProductoBO
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IProductoRepository productoRepository;

        ProductoBO(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            productoRepository = new ProductoRepository(unitOfWork);
        }

    }
}
