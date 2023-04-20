using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Laboratorio8
{
    public class Afiliados
    {
        private string nombrePartido;
        private string dpi;
        private DateTime fechaAfiliacion;

        public string NombrePartido { get => nombrePartido; set => nombrePartido = value; }
        public string DPI { get => dpi; set => dpi = value; }
        public DateTime FechaAfiliacion { get => fechaAfiliacion; set => fechaAfiliacion = value; }

        public void Cargar(StreamReader reader)
        {
            nombrePartido = reader.ReadLine();
            dpi = reader.ReadLine();
            fechaAfiliacion = DateTime.Parse(reader.ReadLine());
        }

        public void Escribir(StreamWriter writer)
        {
            writer.WriteLine(nombrePartido);
            writer.WriteLine(dpi);
            writer.WriteLine(fechaAfiliacion);
        }
    }
}