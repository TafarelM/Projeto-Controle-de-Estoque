using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class VendaDTO
    {
        public int idVenda { get; set; }
        public DateTime data { get; set; }
        public int notaFiscal { get; set; }
        public float total { get; set; }
        public int nParcelas { get; set; }
        public int status { get; set; }
        public int idCliente { get; set; }
        public int idTipoPagamento { get; set; }
    }
}
