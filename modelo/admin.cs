using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class admin : persona
    {
        private int ad_id;
        private string adUser;
        private string adPass;
        private string cargo;
        private int est_id;

        public admin(int p_id, string nombres, string apellidos, string rut, int edad, int num_tlf, int ad_id, string adUser,
            string adPass, string cargo, int est_id) : base(p_id, nombres, apellidos, rut, edad, num_tlf)
        {
            this.ad_id = ad_id;
            this.adUser = adUser;
            this.adPass = adPass;
            this.cargo = cargo;
            this.est_id = est_id;
        }

        public int Ad_id { get => ad_id; set => ad_id = value; }
        public string AdUser { get => adUser; set => adUser = value; }
        public string AdPass { get => adPass; set => adPass = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Est_id { get => est_id; set => est_id = value; }

        override
        public string ToString()
        {
            return base.ToString()
                + ", "
                + ad_id
                + ", "
                + adUser
                + ", "
                + adPass
                + ", "
                + cargo
                + ", "
                + est_id;
        }
    }
}
