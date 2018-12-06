using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntities
{
    public class Pago : IPago
    {
        #region Propiedades

        public int IdPago { get; set; }
        public int IdVenta { get; set; }
        public Venta Venta { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaAbono { get; set; }

        #endregion
    }
}
