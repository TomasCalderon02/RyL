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
    public partial class WebFormLogin : System.Web.UI.Page
    {
        private admin ad;
        private empleado emp;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            username = TextBoxUsuario.Text;
            password = TextBoxClave.Text;

            if(RadioButtonListTipoUsuario.SelectedValue == "")
            {
                LabelMensaje.Text = "Elija un tipo de usuario";
            }
            else
            {
                switch (int.Parse(RadioButtonListTipoUsuario.SelectedValue))
                {
                    case 1:
                        {
                            //empleado
                            emp = Logins.LoginEmp(username, password);
                            if (emp != null)
                            {
                                Session["empleado"] = emp;
                                Response.Redirect("WebFormAgregar.aspx");
                            }
                            else
                            {
                                LabelMensaje.Text = "Inicio de Sesion Fallido";
                            }
                            break;
                        }
                    case 2:
                        {
                            //admin
                            ad = Logins.LoginAdmin(username, password);
                            if (ad != null)
                            {
                                Session["admin"] = ad;
                                Response.Redirect("WebFormDashboard.aspx");
                            }
                            else
                            {
                                LabelMensaje.Text = "Inicio de Sesion Fallido";
                            }
                            break;
                        }
                }
            }
        }
    }
}