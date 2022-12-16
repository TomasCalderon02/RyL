using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class persona
    {
        private int p_id;

        private string nombres;
        private string apellidos;
        private string rut;

        private int edad;
        private int num_tlf;

        public persona(int p_id, string nombres, string apellidos, string rut, int edad, int num_tlf)
        {
            this.p_id = p_id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.rut = rut;
            this.edad = edad;
            this.num_tlf = num_tlf;
        }

        public int P_id { get => p_id; set => p_id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Rut { get => rut; set => rut = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Num_tlf { get => num_tlf; set => num_tlf = value; }

        override
        public string ToString()
        {
            return p_id
                + ", "
                + nombres
                + ", "
                + apellidos
                + ", "
                + rut
                + ", "
                + edad
                + ", "
                + num_tlf;

        }
    }
}
