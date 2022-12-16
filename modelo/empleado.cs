using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class empleado : persona
    {
        private int emp_id;
        private string nUser;
        private string password;
        private int est_id;

        public empleado(int p_id, string nombres, string apellidos, string rut, int edad, int num_tlf,
            int emp_id, string nUser, string password, int est_id) : base(p_id, nombres, apellidos, rut, edad, num_tlf)
        {
            this.emp_id = emp_id;
            this.nUser = nUser;
            this.password = password;
            this.est_id = est_id;
        }

        public int Emp_id { get => emp_id; set => emp_id = value; }
        public string NUser { get => nUser; set => nUser = value; }
        public string Password { get => password; set => password = value; }
        public int Est_id { get => est_id; set => est_id = value; }

        override
        public string ToString()
        {
            return base.ToString()
                + ", "
                + emp_id
                + ", "
                + nUser
                + ", "
                + password
                + ", "
                + est_id;
        }
    }
}
