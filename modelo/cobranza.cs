using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class cobranza
    {
        private int folio;
        private string fechaIngreso;
        private int total;
        private string comentario;

        public cobranza(int folio, string fechaIngreso, int total, string comentario)
        {
            this.folio = folio;
            this.fechaIngreso = fechaIngreso;
            this.total = total;
            this.comentario = comentario;
        }

        public int Folio { get => folio; set => folio = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Total { get => total; set => total = value; }
        public string Comentario { get => comentario; set => comentario = value; }

        override
        public string ToString()
        {
            return folio + ", "
                + fechaIngreso
                + ", "
                + total
                + ", "
                + comentario;
        }
    }
}
