using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    class CompraDTO
    {
        public int id_compra { get; set; }
        public DateTime data { get; set; }
        public int n_fiscal { get; set; }
        public float total { get; set; }
        public int n_parcelas { get; set; }
        public int status { get; set; }
        public int id_for { get; set; }
        public int id_tpa { get; set; }
    }
}
