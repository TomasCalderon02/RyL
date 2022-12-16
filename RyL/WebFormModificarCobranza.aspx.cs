using dao;
using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RyL
{
    public partial class WebFormModificarCobranza : System.Web.UI.Page
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
                TextBoxTotal.Text = cobro.Total.ToString();
                TextBoxComentario.Text = cobro.Comentario;
            }

        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            int folio;
            string fechaIngreso;
            int total;
            string comentario;

            folio = int.Parse(TextBoxFolio.Text);
            fechaIngreso = TextBoxFechaIngreso.Text;
            total = int.Parse(TextBoxTotal.Text);
            comentario = TextBoxComentario.Text;

            cobranza cobro = new cobranza(folio, fechaIngreso, total, comentario);

            if (cobranzaDAO.modificar(cobro) == true)
            {
                LabelMensaje.Text = "Cobro Modificado";
            }
            else
            {
                LabelMensaje.Text = "Error, Cobro no modificado";
            }
        }
    }
}