using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio8
{
    public class Rep
    {
        private Ciudadano c;
        private Afiliados a;

        public Rep(Ciudadano c, Afiliados a)
        {
            this.c = c;
            this.a = a;
        }

        public string NombreCiudadano { get => c.Nombre; }
        public string PartidoAfiliado { get => a.NombrePartido; }
    }
}