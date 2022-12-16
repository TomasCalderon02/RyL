using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using modelo;

namespace RyL
{
    public partial class WebFormListar : System.Web.UI.Page
    {
        private admin ad;
        private empleado emp;
        protected void Page_Load(object sender, EventArgs e)
        {
            ad = (admin)Session["admin"];
            emp = (empleado)Session["empleado"];

            if (ad != null)
            {
                LabelUsuario.Text = ad.Nombres;
            }
            else if (emp != null)
            {
                LabelUsuario.Text = emp.Nombres;
                dashboard.Visible = false;
                ventas.Visible = false;
                cobranza.Visible = false;
            }
            else
            {
                Response.Redirect("WebFormFinSesion.aspx");
            }
        }
    }
}