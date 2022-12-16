using dao;
using modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RyL
{
    public partial class WebFormVerCobranza : System.Web.UI.Page
    {
        private int folio;
        private admin ad;
        protected void Page_Load(object sender, EventArgs e)
        {
            ad = (admin)Session["admin"];

            if (ad != null)
            {
                LabelUsuario.Text = ad.Nombres;
            }
            else
            {
                Response.Redirect("WebFormFinSesion.aspx");
            }

            if (IsPostBack == false)
            {
                folio = int.Parse(Request.QueryString.Get("id"));

                cobranza cobro = cobranzaDAO.buscar(folio);

                TextBoxFolio.Text = cobro.Folio.ToString();
                TextBoxFechaIngreso.Text = Convert.ToDateTime(cobro.FechaIngreso).Date.ToString("yyyy-MM-dd"); 
                TextBoxTotal.Text = cobro.Total.ToString("C0", CultureInfo.CurrentCulture);
                TextBoxComentario.Text = cobro.Comentario;
            }
        }
    }
}