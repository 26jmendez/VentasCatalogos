using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntities
{
    public class Campania : ICampania
    {
        #region Propiedades

        public int IdCampania { get; set; }
        public string Nombre { get; set; }
        public short Anio { get; set; }
        public Producto Producto { get; set; }
        #endregion

    }
}
