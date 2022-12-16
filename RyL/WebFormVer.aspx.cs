using dao;
using modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RyL
{
    public partial class WebFormVer : System.Web.UI.Page
    {
        private int id;
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

            if (IsPostBack == false)
            {
                id = int.Parse(Request.QueryString.Get("id"));

                ordenTrabajo ot = ordenTrabajoDAO.buscar(id);
                string foto = ot.Montaje;

                TextBoxID.Text = ot.Id.ToString();
                TextBoxFechaIngreso.Text = Convert.ToDateTime(ot.FechaIngreso).Date.ToString("yyyy-MM-dd");
                TextBoxFechaEntrega.Text = Convert.ToDateTime(ot.FechaEntrega).Date.ToString("yyyy-MM-dd");
                TextBoxCliente.Text = ot.Cliente;
                TextBoxTrabajo.Text = ot.Trabajo;
                TextBoxReimpresion.Text = ot.ReimpresionOT.ToString();
                TextBoxCantidad.Text = ot.Cantidad.ToString();
                TextBoxCotizacion.Text = ot.Cotizacion.ToString();
                TextBoxPapel.Text = ot.Papel;
                TextBoxCantPliegos.Text = ot.CantPliegos.ToString();
                TextBoxFormato.Text = ot.Formato;
                TextBoxTamanoArticulo.Text = ot.TamanoArticulo;
                TextBoxTerminado.Text = Convert.ToDateTime(ot.FechaTermino).Date.ToString("yyyy-MM-dd");
                TextBoxFactN.Text = ot.FactN;
                TextBoxGuiaN.Text = ot.GuiaN;
                RadioButtonListPruebaColor.SelectedValue = ot.PruebaColor.ToString();
                RadioButtonListMaqueta.SelectedValue = ot.Maqueta.ToString();
                ImageMontaje.ImageUrl = "~/img/" + foto;
                TextBoxNota.Text = ot.Nota;
                TextBoxTamanoPapel.Text = ot.TamanoPapel;
                TextBoxTamanoTerminado.Text = ot.TamanoTerminado;
                TextBoxTiraje.Text = ot.Tiraje;
                TextBoxSobrante.Text = ot.Sobrante;
                TextBoxOriginal.Text = ot.Original;
                TextBoxCopia.Text = ot.Copia;
                DropDownListMaquina.SelectedValue = ot.Maquina.ToString();
                TextBoxTercero.Text = ot.Tercero;
                TextBoxTinta.Text = ot.Tinta;
                TextBoxTiro.Text = ot.Tiro;
                TextBoxRetiro.Text = ot.Retiro;
                RadioButtonListBarnizO.SelectedValue = ot.BarnizOpaco.ToString();
                RadioButtonListBarnizB.SelectedValue = ot.BarnizBrillante.ToString();
                RadioButtonListTerminacion1.SelectedValue = ot.Terminacion1.ToString();
                CheckBoxListTerminacion2.SelectedValue = ot.Terminacion2.ToString();
                TextBoxFolio.Text = ot.Folio.ToString();
                TextBoxObs.Text = ot.Observacion;
                RadioButtonListEstado.SelectedValue = ot.Estado.ToString();
            }

            Conexion c = new Conexion();
            SqlConnection con = new SqlConnection(c.conectar());
            SqlCommand cmd = new SqlCommand("select Maquina_id, Machine_name from Maquina", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            DropDownListMaquina.DataSource = ds;
            DropDownListMaquina.DataTextField = "Machine_name";
            DropDownListMaquina.DataValueField = "Maquina_id";
            DropDownListMaquina.DataBind();
            con.Close();

        }
    }
}