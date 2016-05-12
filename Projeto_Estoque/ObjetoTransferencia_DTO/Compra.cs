using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class Compra
    {
        public int idCompra { get; set; }
        public DateTime data { get; set; }
        public string notaFiscal { get; set; }
        public decimal total { get; set; }
        public string formaPagamento { get; set; }
        public string status { get; set; }
        public int idFornecedor { get; set; }
        public int idTipoPagamento { get; set; }
    }
}
