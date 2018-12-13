using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntities.Concrete
{
    public class Proveedor : IProveedor
    {
        #region Propiedades

        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }

        #endregion

    }
}
