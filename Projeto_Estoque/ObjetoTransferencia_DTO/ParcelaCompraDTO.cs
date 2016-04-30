using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class ParcelaCompraDTO
    {
        public int idParcelaCompra { get; set; }
        public float valor { get; set; }
        public DateTime dataPagamento { get; set; }
        public DateTime dataVencimento { get; set; }
        public int idCompra { get; set; }
    }
}
