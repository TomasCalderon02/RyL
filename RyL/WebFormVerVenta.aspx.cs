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
    public partial class WebFormVerVENTA : System.Web.UI.Page
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
                TextBoxMontoTotal.Text = v.MontoTotal.ToString("C0", CultureInfo.CurrentCulture);
                TextBoxFechaPago.Text = Convert.ToDateTime(v.FechaPago).Date.ToString("yyyy-MM-dd");
                TextBoxVendedor.Text = v.Vendedor;
            }
        }
    }
}