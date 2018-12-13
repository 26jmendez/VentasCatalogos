﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntities.Concrete
{
    public class Comprador : IComprador
    {
        #region Propiedades

        public int IdComprador { get; set; }
        public string Nombre { get; set; }
        public int IdContacto { get; set; }
        public Contacto Contacto { get; set; }

        #endregion
    }
}
