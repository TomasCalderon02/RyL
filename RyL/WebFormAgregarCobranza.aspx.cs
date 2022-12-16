using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using modelo;
using dao;


namespace RyL
{
    public partial class WebFormAgregarCobranza : System.Web.UI.Page
    {
        int n = 1;
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

            foreach (cobranza cobro in cobranzaDAO.ObtenerDatos())
            {
                n++;
            }
            TextBoxFolio.Text = n.ToString();

            //if (IsPostBack == false)
            //{
            //    TextBoxFechaIngreso.Text = "2022-12-20";
            //    TextBoxTotal.Text = "150860";
            //    TextBoxComentario.Text = "Transferencia";
            //}
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
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

            if (cobranzaDAO.agregar(cobro) == true)
            {
                LabelMensaje.Text = "Cobro Agregado";
                limpiar();
            }
            else
            {
                LabelMensaje.Text = "Error, Cobro no Agregado";
            }
        }

        public void limpiar()
        {
            //TextBoxFolio.Text = "";
            TextBoxFechaIngreso.Text = "";
            TextBoxTotal.Text = "";
            TextBoxComentario.Text = "";
        }
    }
}