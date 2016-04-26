using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    class ItemCompraDTO
    {
        public int id_itc { get; set; }
        public int qtd { get; set; }
        public float valor { get; set; }
        public int id_com { get; set; }
        public int id_produto { get; set; }
    }
}
