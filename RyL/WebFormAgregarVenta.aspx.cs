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
    public partial class WebFormAgregarVenta : System.Web.UI.Page
    {
        int n = 1;
        private admin ad;
        protected void Page_Load(object sender, EventArgs e)
        {
            ad = (admin)Session["admin"];

            if (ad != null )
            {
                LabelUsuario.Text = ad.Nombres;
            }
            else
            {
                Response.Redirect("WebFormFinSesion.aspx");
            }

            foreach (venta v in ventaDAO.ObtenerDatos())
            {
                n++;
            }
            TextBoxID.Text = n.ToString();

            //if (IsPostBack == false)
            //{
            //    //TextBoxDoc.Text = "1";
            //    TextBoxRutCliente.Text = "9525882-4";
            //    TextBoxRazonSocial.Text = "Arcos";
            //    TextBoxFolio.Text = "7710";
            //    TextBoxFechaDocto.Text = "2023-01-08";
            //    TextBoxMontoTotal.Text = "250200";
            //    TextBoxFechaPago.Text = "2023-01-09";
            //    TextBoxVendedor.Text = "Javier";
            //}

        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            int id;
            int adID;
            int doc;
            string rutCliente;
            string razonSocial;
            int folio;
            string fechaDocto;
            int montoTotal;
            string fechaPago;
            string vendedor;

            id = int.Parse(TextBoxID.Text);
            adID = ad.Ad_id;
            doc = int.Parse(DropDownListDoc.SelectedValue);
            rutCliente = TextBoxRutCliente.Text;
            razonSocial = TextBoxRazonSocial.Text;
            folio = int.Parse(TextBoxFolio.Text);
            fechaDocto = TextBoxFechaDocto.Text;
            montoTotal = int.Parse(TextBoxMontoTotal.Text);
            fechaPago = TextBoxFechaPago.Text;
            vendedor = TextBoxVendedor.Text;

            venta v = new venta(id, adID, doc, rutCliente, razonSocial, folio, fechaDocto, montoTotal, fechaPago, vendedor);

            if (ventaDAO.agregar(v) == true)
            {
                LabelMensaje.Text = "Venta Agregada";
                limpiar();
            }
            else
            {
                LabelMensaje.Text = "Error, Venta no Agregada";
            }
        }
        public void limpiar()
        {
            //TextBoxID.Text;
            //TextBoxDoc.Text = "";
            TextBoxRutCliente.Text = "";
            TextBoxRazonSocial.Text = "";
            TextBoxFolio.Text = "";
            TextBoxFechaDocto.Text = "";
            TextBoxMontoTotal.Text = "";
            TextBoxFechaPago.Text = "";
            TextBoxVendedor.Text = "";
        }
    
    }
}