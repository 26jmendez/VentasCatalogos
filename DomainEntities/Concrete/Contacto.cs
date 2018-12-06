using System.Collections.Generic;

namespace DomainEntities
{
    public class Contacto : IContacto
    {
        #region Propiedades

        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public ICollection<Comprador> Compradores { get; set; }

        #endregion

        #region Métodos

        public Contacto ObtenerContactoConCompradores()
        {
            return new Contacto();
        }

        #endregion
    }
}