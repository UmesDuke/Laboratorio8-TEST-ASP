using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Laboratorio8
{
    public class Ciudadano
    {
        private string dpi;
        private string nombre;
        private string direccion;

        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public void Cargar(StreamReader reader)
        {
            dpi = reader.ReadLine();
            nombre = reader.ReadLine();
            direccion = reader.ReadLine();
        }
    }
}