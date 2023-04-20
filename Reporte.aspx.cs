using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio8
{
    public partial class Reporte : System.Web.UI.Page
    {
        Maestro m = new Maestro();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void MostrarDatos(bool ordenar)
        {
            string path = Server.MapPath("/Archivos");
            m.RootPath = path;
            m.Cargar();

            List<Rep> dataRep = new List<Rep>();
            foreach (Afiliados a in m.Afiliados)
            {
                Ciudadano c = m.GetCiudadano(a.DPI);
                if (c != null)
                {
                    dataRep.Add(new Rep(c, a));
                }
            }

            if (ordenar)
            {
                dataRep = dataRep.OrderBy(p => p.PartidoAfiliado).ToList();
            }

            GridView1.DataSource = dataRep;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MostrarDatos(false);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MostrarDatos(true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("/Archivos");
            m.RootPath = path;
            m.Cargar();

            LabelTotal.Text = m.Afiliados.Count.ToString();
        }
    }
}