using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    class VendaDTO
    {
        public int id_venda { get; set; }
        public DateTime data { get; set; }
        public int n_fiscal { get; set; }
        public float total { get; set; }
        public int n_parcelas { get; set; }
        public int status { get; set; }
        public int id_cliente { get; set; }
        public int tpa_cod { get; set; }
    }
}
