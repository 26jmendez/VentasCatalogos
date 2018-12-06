using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntities
{
    public class Venta : IVenta
    {
        #region Propiedades

        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        public int IdCampania { get; set; }
        public Campania Campania { get; set; }
        public DateTime FechaVenta { get; set; }
        public ICollection<Pago> Pagos { get; set; }

        #endregion
    }
}
