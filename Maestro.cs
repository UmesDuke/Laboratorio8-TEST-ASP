using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Laboratorio8
{
    public class Maestro
    {
        private List<Ciudadano> ciudadanos = new List<Ciudadano>();
        private List<Afiliados> afiliados = new List<Afiliados>();
        private string rootPath;

        public string RootPath { get => rootPath; set => rootPath = value; }    
        internal List<Ciudadano> Ciudadanos { get => ciudadanos; set => ciudadanos = value; }
        internal List<Afiliados> Afiliados { get => afiliados; set => afiliados = value; }

        public void addAfilidado(Afiliados a)
        {
            this.afiliados.Add(a);
        }

        public Ciudadano GetCiudadano(string dpi)
        {
            foreach (Ciudadano f in ciudadanos)
            {
                if (f.Dpi.Equals(dpi))
                {
                    return f;
                }
            }
            return null;
        }

        public Afiliados GetAfiliadp(Ciudadano c)
        {
            foreach (Afiliados f in afiliados)
            {
                if (f.DPI.Equals(c.Dpi))
                {
                    return f;
                }
            }
            return null;
        }

        public void Cargar()
        {
            StreamReader reader = GetReader("Ciudadanos.txt");
            while (reader.Peek() > -1)
            {
                Ciudadano c = new Ciudadano();
                c.Cargar(reader);
                ciudadanos.Add(c);
            }
            reader.Close();


            reader = GetReader("Afiliados.txt");
            while (reader.Peek() > -1)
            {
                Afiliados a = new Afiliados();
                a.Cargar(reader);
                afiliados.Add(a);
            }
            reader.Close();
        }

        public void Guardar()
        {
            StreamWriter writer  = GetWriter("Afiliados.txt");
            foreach (Afiliados c in afiliados)
            {
                c.Escribir(writer);
            }
            writer.Close();
        }

        private StreamReader GetReader(string path)
        {
            return new StreamReader(new FileStream(rootPath + '/' + path, FileMode.OpenOrCreate, FileAccess.Read));
        }

        private StreamWriter GetWriter(string path)
        {
            return new StreamWriter(new FileStream(rootPath + '/' + path, FileMode.OpenOrCreate, FileAccess.Write));
        }

    }
}