using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class ParcelaVenda
    {
        public int idVenda { get; set; }
        public int idParcelaVenda { get; set; }
        public float valor { get; set; }
        public DateTime dataPagamento { get; set; }
        public DateTime dataVencimento { get; set; }
    }
}
