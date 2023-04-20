using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio8
{
    public partial class _Default : Page
    {
        private Maestro m = new Maestro();

        protected void Page_Load(object sender, EventArgs e)
        {

            string path = Server.MapPath("/Archivos");
            m.RootPath = path;
            m.Cargar();

            if (!IsPostBack)
            {
                DropDownList1.DataSource = m.Ciudadanos;
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataValueField = "dpi";
                DropDownList1.DataBind();
                return;
            }
        }

        protected void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            string value = DropDownList1.Text;

            Ciudadano c = m.GetCiudadano(value);
            if (c != null)
            {
                Afiliados a = new Afiliados();
                a.DPI = c.Dpi;
                a.NombrePartido = TextBoxPartido.Text;
                a.FechaAfiliacion = DateTime.Now;

                m.addAfilidado(a);
                m.Guardar();
            }
        }
    }
}