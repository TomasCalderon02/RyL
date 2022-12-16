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
    public partial class WebFormModificaVenta : System.Web.UI.Page
    {
        private int id;
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
                id = int.Parse(Request.QueryString.Get("id"));

                venta v = ventaDAO.buscar(id);

                TextBoxID.Text = v.Id.ToString();
                DropDownListDoc.SelectedValue = v.Doc.ToString();
                TextBoxRutCliente.Text = v.RutCliente;
                TextBoxRazonSocial.Text = v.RazonSocial;
                TextBoxFolio.Text = v.Folio.ToString();
                TextBoxFechaDocto.Text = Convert.ToDateTime(v.FechaDocto).Date.ToString("yyyy-MM-dd");
                TextBoxMontoTotal.Text = v.MontoTotal.ToString();
                TextBoxFechaPago.Text = Convert.ToDateTime(v.FechaPago).Date.ToString("yyyy-MM-dd");
                TextBoxVendedor.Text = v.Vendedor;
            }
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
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

            if (ventaDAO.modificar(v) == true)
            {
                LabelMensaje.Text = "Venta Modificada";
                //limpiar();
            }
            else
            {
                LabelMensaje.Text = "Error, Venta no Modificada";
            }
        }
    }
}