using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    class ParcelaCompraDTO
    {
        public int id_parcela_compra { get; set; }
        public float valor { get; set; }
        public DateTime data_pagamento { get; set; }
        public DateTime data_vencimento { get; set; }
        public int id_compra { get; set; }
    }
}
