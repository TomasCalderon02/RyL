using modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class Logins
    {
        public static admin LoginAdmin(string username, string password)
        {
            admin ad = null;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("select Personas.P_id, Personas.Nombres, Personas.Apellidos, Personas.Rut, Personas.Edad, Personas.Num_tlf, Administrador.AD_id, Administrador.ADUser, Administrador.ADPassword, Administrador.Cargo, Administrador.Est_id from Personas, Administrador where Personas.P_id = Administrador.P_id AND ADUser = @username AND ADPassword = @password and Est_id=1", con);

                sSel.Parameters.AddWithValue("@username", username);
                sSel.Parameters.AddWithValue("@password", password);

                SqlDataAdapter da;
                DataTable dt = new DataTable();

                da = new SqlDataAdapter(sSel);
                da.Fill(dt);

                //de la fila , columna de la tabla obtenida
                int p_id = int.Parse(dt.Rows[0][0].ToString());
                string nombres = dt.Rows[0][1].ToString();
                string apellidos = dt.Rows[0][2].ToString();
                string rut = dt.Rows[0][3].ToString();
                int edad = int.Parse(dt.Rows[0][4].ToString());
                int num_tlf = int.Parse(dt.Rows[0][5].ToString());
                int ad_id = int.Parse(dt.Rows[0][6].ToString());
                string adUser = dt.Rows[0][7].ToString();
                string adPass = dt.Rows[0][8].ToString();
                string cargo = dt.Rows[0][9].ToString();
                int est_id = int.Parse(dt.Rows[0][10].ToString());

                ad = new admin(p_id, nombres, apellidos, rut, edad, num_tlf, ad_id, adUser,
                    adPass, cargo, est_id);
            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
            }
            return ad;
        }

        public static empleado LoginEmp(string username, string password)
        {
            //usuario user = null;
            empleado emp = null;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("select Personas.P_id, Personas.Nombres, Personas.Apellidos, Personas.Rut, Personas.Edad, Personas.Num_tlf, EmpImprenta.Emp_id, EmpImprenta.NUser, EmpImprenta.Password, EmpImprenta.Est_id from Personas, EmpImprenta where Personas.P_id = EmpImprenta.P_id AND NUser = @username AND Password = @password and Est_id=1", con);

                sSel.Parameters.AddWithValue("@username", username);
                sSel.Parameters.AddWithValue("@password", password);

                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(sSel);

                da.Fill(dt);

                //de la fila , columna de la tabla obtenida

                int p_id = int.Parse(dt.Rows[0][0].ToString());
                string nombres = dt.Rows[0][1].ToString();
                string apellidos = dt.Rows[0][2].ToString();
                string rut = dt.Rows[0][3].ToString();
                int edad = int.Parse(dt.Rows[0][4].ToString());
                int num_tlf = int.Parse(dt.Rows[0][5].ToString());
                int emp_id = int.Parse(dt.Rows[0][6].ToString());
                username = dt.Rows[0][7].ToString();
                password = dt.Rows[0][8].ToString();
                int est_id = int.Parse(dt.Rows[0][9].ToString());

                emp = new empleado(p_id, nombres, apellidos, rut, edad, num_tlf,
                    emp_id, username, password, est_id);
            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
            }
            return emp;
        }
    }
}
