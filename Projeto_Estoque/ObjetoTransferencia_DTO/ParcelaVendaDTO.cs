﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    class ParcelaVendaDTO
    {
        public int id_venda { get; set; }
        public int id_parcela_venda { get; set; }
        public float valor { get; set; }
        public DateTime data_pagamento { get; set; }
        public DateTime data_vencimento { get; set; }
    }
}