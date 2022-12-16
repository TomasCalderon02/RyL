using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using modelo;
using dao;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace RyL
{
    public partial class WebFormDashboard : System.Web.UI.Page
    {
        private admin ad;
        int n = 0, cantidadVentas = 0, ganancias = 0, cobranzasPendientes = 0, cobroTotal = 0;
        double terminadas, pendientes = 0;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            ad = (admin)Session["admin"];
            

            if (ad == null /*|| user.TipoUsuario == 1*/)
            {
                Response.Redirect("WebFormFinSesion.aspx");
            }
            else
            {
                LabelUsuario.Text = ad.Nombres;
                foreach (ordenTrabajo ot in ordenTrabajoDAO.ObtenerDatos())
                {
                    if (ot.Estado == 0)
                    {
                        pendientes++;
                    }
                    else
                    {
                        terminadas++;
                    }
                    n++;
                }
                pendientes = (pendientes / n);
                terminadas = (terminadas / n);
                LabelPendientes.Text = pendientes.ToString("P0", CultureInfo.CurrentCulture);
                LabelTerminados.Text = terminadas.ToString("P0", CultureInfo.CurrentCulture);

                foreach (venta v in ventaDAO.ObtenerDatos())
                {
                    cantidadVentas++;
                    ganancias = ganancias + v.MontoTotal;
                }

                LabelVentas.Text = cantidadVentas.ToString();
                LabelMontoTotal.Text = ganancias.ToString("C0", CultureInfo.CurrentCulture);

                foreach (cobranza cobro in cobranzaDAO.ObtenerDatos())
                {
                    cobranzasPendientes++;
                    cobroTotal = cobroTotal + cobro.Total;
                }

                LabelCobranzaPendiente.Text = cobranzasPendientes.ToString();
                LabelCobroTotal.Text = cobroTotal.ToString("C0", CultureInfo.CurrentCulture);

                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());

                DataSet ds2 = new DataSet();
                SqlDataAdapter da2 = new SqlDataAdapter("select OT.OT_id as ID, Cliente.Nombre as Cliente , CASE WHEN Estado = 0 then 'Pendiente' ELSE 'Terminado' END AS Estado from OT, Cliente where Estado=0 AND Cliente.Rut_Cliente = OT.Rut_cliente", con);
                da2.Fill(ds2);
                GridView2.DataSource = ds2;
                GridView2.DataBind();

                DataSet ds3 = new DataSet();
                SqlDataAdapter da3 = new SqlDataAdapter("select OT.OT_id as ID, Cliente.Nombre as Cliente , CASE WHEN Estado = 0 then 'Pendiente' ELSE 'Terminado' END AS Estado from OT, Cliente where Estado=1 AND Cliente.Rut_Cliente = OT.Rut_cliente", con);
                da3.Fill(ds3);
                GridView3.DataSource = ds3;
                GridView3.DataBind();

                con.Close();
            }
        }
    }
}