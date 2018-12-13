using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntities.Concrete
{
    public class Producto : IProducto
    {
        #region Propiedades

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        public int Pagina { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal Costo { get; set; }
        public int IdCampania { get; set; }
        public Campania Campania { get; set; }

        #endregion
    }
}
